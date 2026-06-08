namespace ServiceCenter.Forms
{
    partial class SelectPartForm
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
            btnCancel = new Button();
            btnSelect = new Button();
            dgvSelect = new DataGridView();
            txtSearch = new TextBox();
            numQuantity = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(176, 244);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 23);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(10, 244);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(160, 23);
            btnSelect.TabIndex = 21;
            btnSelect.Text = "Добавить";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // dgvSelect
            // 
            dgvSelect.AllowUserToAddRows = false;
            dgvSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelect.BackgroundColor = SystemColors.Control;
            dgvSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelect.Location = new Point(12, 37);
            dgvSelect.Name = "dgvSelect";
            dgvSelect.ReadOnly = true;
            dgvSelect.RowHeadersVisible = false;
            dgvSelect.Size = new Size(324, 156);
            dgvSelect.TabIndex = 20;
            dgvSelect.CellDoubleClick += dgvSelect_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск";
            txtSearch.Size = new Size(324, 23);
            txtSearch.TabIndex = 19;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(12, 215);
            numQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(322, 23);
            numQuantity.TabIndex = 23;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 197);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 24;
            label1.Text = "Количество";
            // 
            // SelectPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 279);
            Controls.Add(label1);
            Controls.Add(numQuantity);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            Controls.Add(dgvSelect);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SelectPartForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Выбор запчасти";
            ((System.ComponentModel.ISupportInitialize)dgvSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSelect;
        public DataGridView dgvSelect;
        private TextBox txtSearch;
        private NumericUpDown numQuantity;
        private Label label1;
    }
}