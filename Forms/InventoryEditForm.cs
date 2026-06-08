using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ServiceCenter.Forms
{
    public partial class InventoryEditForm : Form
    {
        private int? _itemId = null;

        public InventoryEditForm()
        {
            InitializeComponent();
            this.Text = "Добавить запчасть";
        }

        public InventoryEditForm(int id, string name, string articul, int quantity, decimal price) : this()
        {
            _itemId = id;
            txtName.Text = name;
            txtArticul.Text = articul; 
            numQuantity.Value = quantity;
            numPrice.Value = price;
            this.Text = "Редактировать запчасть";
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
             MessageBox.Show("Введите название запчасти!");
             return;
          }

            this.DialogResult = DialogResult.OK;
            this.Close();
         }
    }
}
