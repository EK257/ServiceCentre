using System.Windows.Forms;
using System.Drawing;

namespace ServiceCenter
{
    public static class UIHelper
    {
        public static void FormatOrdersTable(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0) return;

            if (dgv.Columns.Contains("№ Заказа"))
                dgv.Columns["№ Заказа"].FillWeight = 60;

            if (dgv.Columns.Contains("Клиент"))
                dgv.Columns["Клиент"].FillWeight = 150;

            if (dgv.Columns.Contains("Устройство"))
                dgv.Columns["Устройство"].FillWeight = 120;

            if (dgv.Columns.Contains("Статус"))
                dgv.Columns["Статус"].FillWeight = 90;

            if (dgv.Columns.Contains("Сумма"))
            {
                dgv.Columns["Сумма"].DefaultCellStyle.Format = "0.00";
                dgv.Columns["Сумма"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
            }

            if (dgv.Columns.Contains("Дата"))
            {
                dgv.Columns["Дата"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }

            StandardDesign(dgv);
        }

        public static void FormatSelectionTable(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0) return;

            if (dgv.Columns.Contains("Id"))
                dgv.Columns["Id"].Visible = false;

            if (dgv.Columns.Contains("Name"))
                dgv.Columns["Name"].HeaderText = "Наименование";

            if (dgv.Columns.Contains("Price"))
            {
                dgv.Columns["Price"].HeaderText = "Цена";
                dgv.Columns["Price"].DefaultCellStyle.Format = "0.00";
                dgv.Columns["Price"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
            }

            if (dgv.Columns.Contains("Quantity"))
                dgv.Columns["Quantity"].HeaderText = "Остаток";

            if (dgv.Columns.Contains("Articul"))
                dgv.Columns["Articul"].HeaderText = "Артикул";

            StandardDesign(dgv);
        }

        public static void FormatOrderItemsTable(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0) return;

            if (dgv.Columns.Contains("ItemType"))
                dgv.Columns["ItemType"].Visible = false;

            if (dgv.Columns.Contains("ItemId"))
                dgv.Columns["ItemId"].Visible = false;

            if (dgv.Columns.Contains("Name"))
                dgv.Columns["Name"].HeaderText = "Наименование";

            if (dgv.Columns.Contains("Quantity"))
                dgv.Columns["Quantity"].HeaderText = "Кол-во";

            if (dgv.Columns.Contains("Price"))
            {
                dgv.Columns["Price"].HeaderText = "Цена";
                dgv.Columns["Price"].DefaultCellStyle.Format = "0.00";
                dgv.Columns["Price"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
            }

            StandardDesign(dgv);
        }

        private static void StandardDesign(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
        }
    }
}