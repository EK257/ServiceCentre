using ServiceCenter.Data;
using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace ServiceCenter.Forms
{
    public partial class MainForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public MainForm()
        {
            InitializeComponent();
            dgvOrders.DataError += (s, e) => { e.ThrowException = false; };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshAllData();
        }

        public void RefreshAllData()
        {
            RefreshOrders();
            RefreshServices();
            RefreshInventory();
        }

        public void RefreshOrders()
        {
            string sql = @"
            SELECT 
                Id AS [№ Заказа],
                ClientName AS [Клиент],
                DeviceType AS [Тип],
                DeviceModel AS [Модель],
                DeviceSerial AS [Серийный],
                Status AS [Статус],
                TotalPrice AS [Сумма],
                strftime('%Y-%m-%d %H:%M:%S', CreatedDate) AS [Дата]
            FROM Orders
            ORDER BY Id DESC";
            dgvOrders.DataSource = null;
            dgvOrders.Columns.Clear();
            dgvOrders.DataSource = db.ExecuteQuery(sql);
            UIHelper.FormatOrdersTable(dgvOrders);
        }

        public void RefreshServices()
        {
            string sql = "SELECT Id, Name, Price FROM Services";
            dgvServices.DataSource = null;
            dgvServices.Columns.Clear();
            dgvServices.DataSource = db.ExecuteQuery(sql);
            UIHelper.FormatSelectionTable(dgvServices);
        }

        public void RefreshInventory()
        {
            string sql = "SELECT Id, Name, Articul, Quantity, Price FROM Inventory";
            dgvInventory.DataSource = null;
            dgvInventory.Columns.Clear();
            dgvInventory.DataSource = db.ExecuteQuery(sql);
            UIHelper.FormatSelectionTable(dgvInventory);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            using (var f = new OrderEditForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshOrders();
                    RefreshInventory();
                }
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvOrders.CurrentRow.Cells["№ Заказа"].Value);

            using (var f = new OrderEditForm(id))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshOrders();
                    RefreshInventory();
                }
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvOrders.CurrentRow.Cells["№ Заказа"].Value);

            var result = MessageBox.Show("Удалить заказ?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            db.ExecuteNonQuery("DELETE FROM Orders WHERE Id=@id",
                new[] { new SqliteParameter("@id", id) });

            RefreshOrders();
        }

        private void tbSearchOrder_TextChanged(object sender, EventArgs e)
        {
            string sql = @"
            SELECT 
                Id AS [№ Заказа],
                ClientName AS [Клиент],
                DeviceType AS [Тип],
                DeviceModel AS [Модель],
                DeviceSerial AS [Серийный],
                Status AS [Статус],
                TotalPrice AS [Сумма],
                strftime('%d.%m.%Y %H:%M', CreatedDate) AS [Дата]
            FROM Orders
            WHERE ClientName LIKE @s OR DeviceModel LIKE @s
            ORDER BY Id DESC";

            SqliteParameter[] p =
            {
                new SqliteParameter("@s", "%" + tbSearchOrder.Text + "%")
            };
            dgvOrders.DataSource = null;
            dgvOrders.Columns.Clear();
            dgvOrders.DataSource = db.ExecuteQuery(sql, p);
            UIHelper.FormatOrdersTable(dgvOrders);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            using (var f = new ServiceEditForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string sql = "INSERT INTO Services (Name, Price) VALUES (@n, @p)";
                    db.ExecuteNonQuery(sql, new[]
                    {
                        new SqliteParameter("@n", f.txtName.Text),
                        new SqliteParameter("@p", f.numPrice.Value)
                    });

                    RefreshServices();
                }
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            if (dgvServices.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvServices.CurrentRow.Cells["Id"].Value);

            using (var f = new ServiceEditForm())
            {
                f.txtName.Text = dgvServices.CurrentRow.Cells["Name"].Value.ToString();
                f.numPrice.Value = Convert.ToDecimal(dgvServices.CurrentRow.Cells["Price"].Value);

                if (f.ShowDialog() == DialogResult.OK)
                {
                    string sql = "UPDATE Services SET Name=@n, Price=@p WHERE Id=@id";

                    db.ExecuteNonQuery(sql, new[]
                    {
                        new SqliteParameter("@n", f.txtName.Text),
                        new SqliteParameter("@p", f.numPrice.Value),
                        new SqliteParameter("@id", id)
                    });

                    RefreshServices();
                }
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (dgvServices.CurrentRow == null) return;

            string name = dgvServices.CurrentRow.Cells["Name"].Value.ToString();
            int id = Convert.ToInt32(dgvServices.CurrentRow.Cells["Id"].Value);

            var result = MessageBox.Show($"Удалить услугу '{name}'?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                db.ExecuteNonQuery("DELETE FROM Services WHERE Id=@id",
                    new[] { new SqliteParameter("@id", id) });
                RefreshServices();
            }
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            using (var f = new InventoryEditForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string sql = @"
                    INSERT INTO Inventory (Name, Articul, Quantity, Price)
                    VALUES (@n,@a,@q,@p)";

                    db.ExecuteNonQuery(sql, new[]
                    {
                        new SqliteParameter("@n", f.txtName.Text),
                        new SqliteParameter("@a", f.txtArticul.Text),
                        new SqliteParameter("@q", (int)f.numQuantity.Value),
                        new SqliteParameter("@p", f.numPrice.Value)
                    });

                    RefreshInventory();
                }
            }
        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvInventory.CurrentRow.Cells["Id"].Value);

            using (var f = new InventoryEditForm())
            {
                f.txtName.Text = dgvInventory.CurrentRow.Cells["Name"].Value.ToString();
                f.txtArticul.Text = dgvInventory.CurrentRow.Cells["Articul"].Value.ToString();
                f.numQuantity.Value = Convert.ToDecimal(dgvInventory.CurrentRow.Cells["Quantity"].Value);
                f.numPrice.Value = Convert.ToDecimal(dgvInventory.CurrentRow.Cells["Price"].Value);

                if (f.ShowDialog() == DialogResult.OK)
                {
                    string sql = @"
                    UPDATE Inventory
                    SET Name=@n, Articul=@a, Quantity=@q, Price=@p
                    WHERE Id=@id";

                    db.ExecuteNonQuery(sql, new[]
                    {
                        new SqliteParameter("@n", f.txtName.Text),
                        new SqliteParameter("@a", f.txtArticul.Text),
                        new SqliteParameter("@q", (int)f.numQuantity.Value),
                        new SqliteParameter("@p", f.numPrice.Value),
                        new SqliteParameter("@id", id)
                    });

                    RefreshInventory();
                }
            }
        }

        private void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null) return;

            string name = dgvInventory.CurrentRow.Cells["Name"].Value.ToString();
            int id = Convert.ToInt32(dgvInventory.CurrentRow.Cells["Id"].Value);

            var result = MessageBox.Show($"Удалить товар '{name}' со склада?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                db.ExecuteNonQuery("DELETE FROM Inventory WHERE Id=@id",new[] { new SqliteParameter("@id", id) });
                RefreshInventory();
            }
        }

        private void tbSearchInventory_TextChanged(object sender, EventArgs e)
        {
            string sql = @"
            SELECT Id, Name, Articul, Quantity, Price
            FROM Inventory
            WHERE Name LIKE @s OR Articul LIKE @s";

            dgvInventory.DataSource = db.ExecuteQuery(sql,new[] { new SqliteParameter("@s", "%" + tbSearchInventory.Text + "%") });
        }

        private void tbSearchService_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Id, Name, Price FROM Services WHERE Name LIKE @s";
            SqliteParameter[] p = { new SqliteParameter("@s", "%" + tbSearchService.Text + "%") };

            dgvServices.DataSource = db.ExecuteQuery(sql, p);
            UIHelper.FormatSelectionTable(dgvServices);
        }
    }
}