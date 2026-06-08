using System;
using System.Data;
using ServiceCenter.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace ServiceCenter.Forms
{
    public partial class SelectServiceForm : Form
    {
        public int SelectedId { get; private set; }
        public string SelectedName { get; private set; }
        public decimal SelectedPrice { get; private set; }

        private DatabaseHelper db = new DatabaseHelper();

        public SelectServiceForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string search = "")
        {
            try
            {
                string sql = "SELECT Id, Name, Price FROM Services";
                SqliteParameter[] parameters = null;

                if (!string.IsNullOrEmpty(search))
                {
                    sql += " WHERE Name LIKE @search";
                    parameters = new SqliteParameter[]
                    {
                        new SqliteParameter("@search", "%" + search + "%")
                    };
                }

                DataTable dt = db.ExecuteQuery(sql, parameters);
                dgvSelect.DataSource = dt;

                UIHelper.FormatSelectionTable(dgvSelect);

                if (dgvSelect.Rows.Count > 0)
                    dgvSelect.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки услуг: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvSelect.CurrentRow != null)
            {
                SelectedId = Convert.ToInt32(dgvSelect.CurrentRow.Cells["Id"].Value);
                SelectedName = dgvSelect.CurrentRow.Cells["Name"].Value.ToString();
                SelectedPrice = Convert.ToDecimal(dgvSelect.CurrentRow.Cells["Price"].Value);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvSelect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelect_Click(sender, e);
        }
    }
}