using ServiceCenter.Data;
using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace ServiceCenter.Forms
{
    public partial class OrderEditForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private int? orderId;
        private DataTable orderItems = new DataTable();

        public OrderEditForm()
        {
            InitializeComponent();
            Init();
            Text = "Добавление заказа";
        }

        public OrderEditForm(int id)
        {
            InitializeComponent();
            orderId = id;
            Init();
            LoadOrder();
            Text = "Редактирование заказа";
        }

        private void Init()
        {
            cmbDeviceType.Items.AddRange(new object[] {
                "Блок питания",
                "Видеокамера",
                "Видеокарта",
                "VR-шлем",
                "Геймпад",
                "Жесткий диск/SSD",
                "ИБП",
                "Мышь/Клавиатура",
                "Квадрокоптер",
                "Колонки",
                "Консоль",
                "Кофемашина",
                "Материнская плата",
                "Микрофон",
                "МФУ",
                "Монитор",
                "Моноблок",
                "Музыкальный центр",
                "Наушники",
                "Ноутбук",
                "ПК",
                "Планшет",
                "Принтер",
                "Проектор",
                "Робот-пылесос",
                "Роутер",
                "Сервер",
                "Сканер",
                "Смарт-часы",
                "Телевизор",
                "Телефон",
                "Усилитель",
                "Фотоаппарат",
                "Экшн-камера",
                "Электронная книга",
                "Другое"
            });
            cmbDeviceType.SelectedIndex = 0;
            cmbStatus.Items.AddRange(new object[] { "Принят", "В работе", "Готов", "Выдан" });
            cmbStatus.SelectedIndex = 0;

            orderItems = new DataTable();
            orderItems.Columns.Add("ItemType", typeof(string));
            orderItems.Columns.Add("ItemId", typeof(int));
            orderItems.Columns.Add("Name", typeof(string));
            orderItems.Columns.Add("Quantity", typeof(int));
            orderItems.Columns.Add("Price", typeof(decimal));

            dgvOrderItems.DataSource = orderItems;
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpOrderDate.Value = DateTime.Now;

            UpdateUI();
        }

        private void UpdateUI()
        {
            UIHelper.FormatOrderItemsTable(dgvOrderItems);
            CalcTotal();
        }

        private void LoadOrder()
        {
            var dt = db.ExecuteQuery("SELECT * FROM Orders WHERE Id=@id", new[] { new SqliteParameter("@id", orderId) });
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            txtClientName.Text = r["ClientName"].ToString();
            txtClientPhone.Text = r["ClientPhone"].ToString();
            cmbDeviceType.Text = r["DeviceType"].ToString();
            txtDeviceModel.Text = r["DeviceModel"].ToString();
            txtDeviceSerial.Text = r["DeviceSerial"].ToString();
            cmbStatus.Text = r["Status"].ToString();
            txtProblem.Text = r["Problem"].ToString();
            if (DateTime.TryParse(r["CreatedDate"].ToString(), out DateTime d)) dtpOrderDate.Value = d;

            LoadItems();
        }

        private void LoadItems()
        {
            orderItems.Clear();
            var dt = db.ExecuteQuery("SELECT * FROM OrderDetails WHERE OrderId=@id", new[] { new SqliteParameter("@id", orderId) });
            foreach (DataRow r in dt.Rows)
            {
                string type = r["ItemType"].ToString();
                int id = Convert.ToInt32(r["ItemId"]);
                orderItems.Rows.Add(type, id, GetItemName(type, id), Convert.ToInt32(r["Quantity"]), Convert.ToDecimal(r["PriceAtTime"]));
            }
            UpdateUI();
        }

        private string GetItemName(string type, int id)
        {
            string table = type == "Service" ? "Services" : "Inventory";
            var dt = db.ExecuteQuery($"SELECT Name FROM {table} WHERE Id=@id", new[] { new SqliteParameter("@id", id) });
            return dt.Rows.Count > 0 ? dt.Rows[0]["Name"].ToString() : "Удалено";
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            using (var f = new SelectServiceForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    orderItems.Rows.Add("Service", f.SelectedId, f.SelectedName, 1, f.SelectedPrice);
                    UpdateUI();
                }
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            using (var f = new SelectPartForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    db.ExecuteNonQuery("UPDATE Inventory SET Quantity = Quantity - @q WHERE Id = @id",
                        new[] {
                            new SqliteParameter("@q", f.SelectedQuantity),
                            new SqliteParameter("@id", f.SelectedId)
                        });

                    orderItems.Rows.Add("Part", f.SelectedId, f.SelectedName, f.SelectedQuantity, f.SelectedPrice);
                    UpdateUI();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.CurrentRow == null) return;

            DataRow row = ((DataRowView)dgvOrderItems.CurrentRow.DataBoundItem).Row;

            if (row["ItemType"].ToString() == "Part")
            {
                db.ExecuteNonQuery("UPDATE Inventory SET Quantity = Quantity + @q WHERE Id = @id",
                    new[] {
                        new SqliteParameter("@q", row["Quantity"]),
                        new SqliteParameter("@id", row["ItemId"])
                    });
            }

            orderItems.Rows.Remove(row);
            UpdateUI();
        }

        private void CalcTotal()
        {
            decimal total = 0;
            foreach (DataRow r in orderItems.Rows)
                total += Convert.ToDecimal(r["Price"]) * Convert.ToInt32(r["Quantity"]);
            lblTotal.Text = $"Итого: {total:0.00} ₽";
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientName.Text)) { MessageBox.Show("Введите имя клиента"); return; }

            if (orderId == null) CreateOrder();
            else UpdateOrder();

            DialogResult = DialogResult.OK;
        }

        private void CreateOrder()
        {
            db.ExecuteNonQuery(@"INSERT INTO Orders (ClientName, ClientPhone, DeviceType, DeviceModel, DeviceSerial, Status, Problem, TotalPrice, CreatedDate)
                                 VALUES (@n,@p,@t,@m,@s,@st,@pr,@tot,@dt)",
                new[] {
                    new SqliteParameter("@n", txtClientName.Text), new SqliteParameter("@p", txtClientPhone.Text),
                    new SqliteParameter("@t", cmbDeviceType.Text), new SqliteParameter("@m", txtDeviceModel.Text),
                    new SqliteParameter("@s", txtDeviceSerial.Text), new SqliteParameter("@st", cmbStatus.Text),
                    new SqliteParameter("@pr", txtProblem.Text), new SqliteParameter("@tot", GetCurrentTotal()),
                    new SqliteParameter("@dt", dtpOrderDate.Value)
                });

            int newId = Convert.ToInt32(db.ExecuteQuery("SELECT last_insert_rowid()").Rows[0][0]);
            SaveItemsOnly(newId);
        }

        private void UpdateOrder()
        {
            db.ExecuteNonQuery(@"UPDATE Orders SET ClientName=@n, ClientPhone=@p, DeviceType=@t, DeviceModel=@m, DeviceSerial=@s, Status=@st, Problem=@pr, TotalPrice=@tot, CreatedDate=@dt WHERE Id=@id",
                new[] {
                    new SqliteParameter("@n", txtClientName.Text), new SqliteParameter("@p", txtClientPhone.Text),
                    new SqliteParameter("@t", cmbDeviceType.Text), new SqliteParameter("@m", txtDeviceModel.Text),
                    new SqliteParameter("@s", txtDeviceSerial.Text), new SqliteParameter("@st", cmbStatus.Text),
                    new SqliteParameter("@pr", txtProblem.Text), new SqliteParameter("@tot", GetCurrentTotal()),
                    new SqliteParameter("@dt", dtpOrderDate.Value), new SqliteParameter("@id", orderId)
                });

            db.ExecuteNonQuery("DELETE FROM OrderDetails WHERE OrderId=@id", new[] { new SqliteParameter("@id", orderId) });
            SaveItemsOnly(orderId.Value);
        }

        private void SaveItemsOnly(int id)
        {
            foreach (DataRow r in orderItems.Rows)
            {
                db.ExecuteNonQuery("INSERT INTO OrderDetails (OrderId, ItemType, ItemId, Quantity, PriceAtTime) VALUES (@o,@t,@i,@q,@p)",
                    new[] {
                        new SqliteParameter("@o", id),
                        new SqliteParameter("@t", r["ItemType"]),
                        new SqliteParameter("@i", r["ItemId"]),
                        new SqliteParameter("@q", r["Quantity"]),
                        new SqliteParameter("@p", r["Price"])
                    });
            }
        }

        private decimal GetCurrentTotal()
        {
            decimal total = 0;
            foreach (DataRow r in orderItems.Rows)
                total += Convert.ToDecimal(r["Price"]) * Convert.ToInt32(r["Quantity"]);
            return total;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}