namespace ServiceCenter.Forms
{
    partial class InventoryEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            txtArticul = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numPrice = new NumericUpDown();
            btnCancel = new Button();
            btnSave = new Button();
            numQuantity = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Название запчасти";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 23);
            txtName.TabIndex = 1;
            // 
            // txtArticul
            // 
            txtArticul.Location = new Point(12, 79);
            txtArticul.Name = "txtArticul";
            txtArticul.Size = new Size(243, 23);
            txtArticul.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Артикул";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Стоимость";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(12, 187);
            numPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(243, 23);
            numPrice.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(182, 223);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 25);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(101, 223);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(12, 133);
            numQuantity.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(243, 23);
            numQuantity.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Количество";
            // 
            // InventoryEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 265);
            Controls.Add(numQuantity);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numPrice);
            Controls.Add(label3);
            Controls.Add(txtArticul);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InventoryEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InventoryEditForm";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtName;
        public TextBox txtArticul;
        private Label label2;
        private Label label3;
        public NumericUpDown numPrice;
        private Button btnCancel;
        private Button btnSave;
        public NumericUpDown numQuantity;
        private Label label4;
    }
}