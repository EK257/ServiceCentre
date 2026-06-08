namespace ServiceCenter.Forms
{
    partial class SelectServiceForm
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
            txtSearch = new TextBox();
            dgvSelect = new DataGridView();
            btnSelect = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSelect).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск";
            txtSearch.Size = new Size(324, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvSelect
            // 
            dgvSelect.AllowUserToAddRows = false;
            dgvSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelect.BackgroundColor = SystemColors.Control;
            dgvSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelect.Location = new Point(12, 41);
            dgvSelect.Name = "dgvSelect";
            dgvSelect.ReadOnly = true;
            dgvSelect.RowHeadersVisible = false;
            dgvSelect.Size = new Size(324, 156);
            dgvSelect.TabIndex = 16;
            dgvSelect.CellDoubleClick += dgvSelect_CellDoubleClick;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(10, 212);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(160, 23);
            btnSelect.TabIndex = 17;
            btnSelect.Text = "Добавить";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(176, 212);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 23);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SelectServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 246);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            Controls.Add(dgvSelect);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SelectServiceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Выбор услуг";
            ((System.ComponentModel.ISupportInitialize)dgvSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        public DataGridView dgvSelect;
        private Button btnSelect;
        private Button btnCancel;
    }
}