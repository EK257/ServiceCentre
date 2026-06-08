namespace ServiceCenter.Forms
{
    partial class OrderEditForm
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
            txtClientName = new TextBox();
            txtClientPhone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDeviceModel = new TextBox();
            label4 = new Label();
            txtProblem = new TextBox();
            label5 = new Label();
            cmbDeviceType = new ComboBox();
            cmbStatus = new ComboBox();
            label6 = new Label();
            txtDeviceSerial = new TextBox();
            label7 = new Label();
            dgvOrderItems = new DataGridView();
            label8 = new Label();
            btnAddService = new Button();
            btnAddPart = new Button();
            btnDelete = new Button();
            lblTotal = new Label();
            btnSaveOrder = new Button();
            btnCancel = new Button();
            label9 = new Label();
            dtpOrderDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Клиент";
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(12, 27);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(172, 23);
            txtClientName.TabIndex = 1;
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(12, 82);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.Size = new Size(172, 23);
            txtClientPhone.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "Номер телефона";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Тип устройства";
            // 
            // txtDeviceModel
            // 
            txtDeviceModel.Location = new Point(12, 203);
            txtDeviceModel.Name = "txtDeviceModel";
            txtDeviceModel.Size = new Size(172, 23);
            txtDeviceModel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "Модель";
            // 
            // txtProblem
            // 
            txtProblem.Location = new Point(239, 27);
            txtProblem.Multiline = true;
            txtProblem.Name = "txtProblem";
            txtProblem.Size = new Size(217, 140);
            txtProblem.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 9);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 8;
            label5.Text = "Описание проблемы";
            // 
            // cmbDeviceType
            // 
            cmbDeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeviceType.FormattingEnabled = true;
            cmbDeviceType.Location = new Point(12, 144);
            cmbDeviceType.Name = "cmbDeviceType";
            cmbDeviceType.Size = new Size(172, 23);
            cmbDeviceType.TabIndex = 10;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(239, 207);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(217, 23);
            cmbStatus.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 189);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 12;
            label6.Text = "Статус";
            // 
            // txtDeviceSerial
            // 
            txtDeviceSerial.Location = new Point(12, 265);
            txtDeviceSerial.Name = "txtDeviceSerial";
            txtDeviceSerial.Size = new Size(172, 23);
            txtDeviceSerial.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 13;
            label7.Text = "Серийный номер";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.BackgroundColor = SystemColors.Control;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(12, 329);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersVisible = false;
            dgvOrderItems.Size = new Size(444, 203);
            dgvOrderItems.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 311);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 16;
            label8.Text = "Корзина";
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(12, 549);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(75, 23);
            btnAddService.TabIndex = 17;
            btnAddService.Text = "+ Услуга";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(93, 549);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(77, 23);
            btnAddPart.TabIndex = 18;
            btnAddPart.Text = "+ Запчасть";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(177, 549);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "- Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(16, 589);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 15);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "Итого: ";
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(272, 589);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(75, 23);
            btnSaveOrder.TabIndex = 21;
            btnSaveOrder.Text = "Сохранить";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(381, 589);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(239, 247);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 23;
            label9.Text = "Дата приемки";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(239, 265);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(217, 23);
            dtpOrderDate.TabIndex = 24;
            // 
            // OrderEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 623);
            Controls.Add(dtpOrderDate);
            Controls.Add(label9);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveOrder);
            Controls.Add(lblTotal);
            Controls.Add(btnDelete);
            Controls.Add(btnAddPart);
            Controls.Add(btnAddService);
            Controls.Add(label8);
            Controls.Add(dgvOrderItems);
            Controls.Add(txtDeviceSerial);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbStatus);
            Controls.Add(cmbDeviceType);
            Controls.Add(txtProblem);
            Controls.Add(label5);
            Controls.Add(txtDeviceModel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtClientPhone);
            Controls.Add(label2);
            Controls.Add(txtClientName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OrderEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OrderEditForm";
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtClientName;
        private TextBox txtClientPhone;
        private Label label2;
        private Label label3;
        private TextBox txtDeviceModel;
        private Label label4;
        private TextBox txtProblem;
        private Label label5;
        private ComboBox cmbDeviceType;
        private ComboBox cmbStatus;
        private Label label6;
        private TextBox txtDeviceSerial;
        private Label label7;
        private DataGridView dgvOrderItems;
        private Label label8;
        private Button btnAddService;
        private Button btnAddPart;
        private Button btnDelete;
        private Label lblTotal;
        private Button btnSaveOrder;
        private Button btnCancel;
        private Label label9;
        private DateTimePicker dtpOrderDate;
    }
}