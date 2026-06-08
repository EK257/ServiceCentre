namespace ServiceCenter.Forms
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tbSearchOrder = new TextBox();
            btnDeleteOrder = new Button();
            btnEditOrder = new Button();
            btnAddOrder = new Button();
            dgvOrders = new DataGridView();
            tabPage2 = new TabPage();
            tbSearchInventory = new TextBox();
            btnDeleteInventory = new Button();
            btnEditInventory = new Button();
            btnAddInventory = new Button();
            dgvInventory = new DataGridView();
            tabPage3 = new TabPage();
            tbSearchService = new TextBox();
            btnDeleteService = new Button();
            btnEditService = new Button();
            btnAddService = new Button();
            dgvServices = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1351, 571);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tbSearchOrder);
            tabPage1.Controls.Add(btnDeleteOrder);
            tabPage1.Controls.Add(btnEditOrder);
            tabPage1.Controls.Add(btnAddOrder);
            tabPage1.Controls.Add(dgvOrders);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1343, 543);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Заказы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbSearchOrder
            // 
            tbSearchOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearchOrder.Location = new Point(1121, 6);
            tbSearchOrder.Name = "tbSearchOrder";
            tbSearchOrder.PlaceholderText = "Поиск";
            tbSearchOrder.Size = new Size(215, 23);
            tbSearchOrder.TabIndex = 4;
            tbSearchOrder.TextChanged += tbSearchOrder_TextChanged;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(169, 6);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(75, 23);
            btnDeleteOrder.TabIndex = 3;
            btnDeleteOrder.Text = "Удалить";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Location = new Point(88, 6);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(75, 23);
            btnEditOrder.TabIndex = 2;
            btnEditOrder.Text = "Изменить";
            btnEditOrder.UseVisualStyleBackColor = true;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(7, 6);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(75, 23);
            btnAddOrder.TabIndex = 1;
            btnAddOrder.Text = "Добавить";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = SystemColors.Control;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(7, 35);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.Size = new Size(1329, 502);
            dgvOrders.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tbSearchInventory);
            tabPage2.Controls.Add(btnDeleteInventory);
            tabPage2.Controls.Add(btnEditInventory);
            tabPage2.Controls.Add(btnAddInventory);
            tabPage2.Controls.Add(dgvInventory);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1343, 543);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Запчасти";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbSearchInventory
            // 
            tbSearchInventory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearchInventory.Location = new Point(1120, 7);
            tbSearchInventory.Name = "tbSearchInventory";
            tbSearchInventory.PlaceholderText = "Поиск";
            tbSearchInventory.Size = new Size(215, 23);
            tbSearchInventory.TabIndex = 8;
            tbSearchInventory.TextChanged += tbSearchInventory_TextChanged;
            // 
            // btnDeleteInventory
            // 
            btnDeleteInventory.Location = new Point(169, 6);
            btnDeleteInventory.Name = "btnDeleteInventory";
            btnDeleteInventory.Size = new Size(75, 23);
            btnDeleteInventory.TabIndex = 7;
            btnDeleteInventory.Text = "Удалить";
            btnDeleteInventory.UseVisualStyleBackColor = true;
            btnDeleteInventory.Click += btnDeleteInventory_Click;
            // 
            // btnEditInventory
            // 
            btnEditInventory.Location = new Point(88, 6);
            btnEditInventory.Name = "btnEditInventory";
            btnEditInventory.Size = new Size(75, 23);
            btnEditInventory.TabIndex = 6;
            btnEditInventory.Text = "Изменить";
            btnEditInventory.UseVisualStyleBackColor = true;
            btnEditInventory.Click += btnEditInventory_Click;
            // 
            // btnAddInventory
            // 
            btnAddInventory.Location = new Point(7, 6);
            btnAddInventory.Name = "btnAddInventory";
            btnAddInventory.Size = new Size(75, 23);
            btnAddInventory.TabIndex = 5;
            btnAddInventory.Text = "Добавить";
            btnAddInventory.UseVisualStyleBackColor = true;
            btnAddInventory.Click += btnAddInventory_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = SystemColors.Control;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(7, 35);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.Size = new Size(1328, 500);
            dgvInventory.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tbSearchService);
            tabPage3.Controls.Add(btnDeleteService);
            tabPage3.Controls.Add(btnEditService);
            tabPage3.Controls.Add(btnAddService);
            tabPage3.Controls.Add(dgvServices);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1343, 543);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Услуги";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbSearchService
            // 
            tbSearchService.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearchService.Location = new Point(1120, 7);
            tbSearchService.Name = "tbSearchService";
            tbSearchService.PlaceholderText = "Поиск";
            tbSearchService.Size = new Size(215, 23);
            tbSearchService.TabIndex = 13;
            tbSearchService.TextChanged += tbSearchService_TextChanged;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Location = new Point(169, 6);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(75, 23);
            btnDeleteService.TabIndex = 12;
            btnDeleteService.Text = "Удалить";
            btnDeleteService.UseVisualStyleBackColor = true;
            btnDeleteService.Click += btnDeleteService_Click;
            // 
            // btnEditService
            // 
            btnEditService.Location = new Point(88, 6);
            btnEditService.Name = "btnEditService";
            btnEditService.Size = new Size(75, 23);
            btnEditService.TabIndex = 11;
            btnEditService.Text = "Изменить";
            btnEditService.UseVisualStyleBackColor = true;
            btnEditService.Click += btnEditService_Click;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(7, 6);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(75, 23);
            btnAddService.TabIndex = 10;
            btnAddService.Text = "Добавить";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.BackgroundColor = SystemColors.Control;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(7, 35);
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersVisible = false;
            dgvServices.Size = new Size(1328, 500);
            dgvServices.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 571);
            Controls.Add(tabControl1);
            MinimumSize = new Size(600, 400);
            Name = "MainForm";
            Text = "Сервисный центр";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvOrders;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnDeleteOrder;
        private Button btnEditOrder;
        private Button btnAddOrder;
        private TextBox tbSearchOrder;
        private TextBox tbSearchInventory;
        private Button btnDeleteInventory;
        private Button btnEditInventory;
        private Button btnAddInventory;
        private DataGridView dgvInventory;
        private TextBox tbSearchService;
        private Button btnDeleteService;
        private Button btnEditService;
        private Button btnAddService;
        private DataGridView dgvServices;
    }
}