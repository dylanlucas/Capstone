namespace GlobalSanicElectronics
{
    partial class EmployeeScreenForm
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
            this.components = new System.ComponentModel.Container();
            this.genericLabel = new System.Windows.Forms.Label();
            this.updateRepairStatus = new System.Windows.Forms.Button();
            this.updateRefundButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.repairStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refundStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateDeliveryStatusButton = new System.Windows.Forms.Button();
            this.deliveryComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.loadCustomerInformationButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gSEDatabaseDataSet = new GlobalSanicElectronics.GSEDatabaseDataSet();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesTableAdapter = new GlobalSanicElectronics.GSEDatabaseDataSetTableAdapters.PurchasesTableAdapter();
            this.tableAdapterManager = new GlobalSanicElectronics.GSEDatabaseDataSetTableAdapters.TableAdapterManager();
            this.refundsTableAdapter = new GlobalSanicElectronics.GSEDatabaseDataSetTableAdapters.RefundsTableAdapter();
            this.repairsTableAdapter = new GlobalSanicElectronics.GSEDatabaseDataSetTableAdapters.RepairsTableAdapter();
            this.refundsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refundsDataGridView = new System.Windows.Forms.DataGridView();
            this.repairsDataGridView = new System.Windows.Forms.DataGridView();
            this.purchasesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefundID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSEDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // genericLabel
            // 
            this.genericLabel.AutoSize = true;
            this.genericLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericLabel.Location = new System.Drawing.Point(588, 6);
            this.genericLabel.Name = "genericLabel";
            this.genericLabel.Size = new System.Drawing.Size(332, 31);
            this.genericLabel.TabIndex = 3;
            this.genericLabel.Text = "Global Sanic Electronics";
            // 
            // updateRepairStatus
            // 
            this.updateRepairStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRepairStatus.Location = new System.Drawing.Point(59, 214);
            this.updateRepairStatus.Name = "updateRepairStatus";
            this.updateRepairStatus.Size = new System.Drawing.Size(223, 57);
            this.updateRepairStatus.TabIndex = 6;
            this.updateRepairStatus.Text = "Update Repair Status";
            this.updateRepairStatus.UseVisualStyleBackColor = true;
            this.updateRepairStatus.Click += new System.EventHandler(this.updateRepairStatus_Click);
            // 
            // updateRefundButton
            // 
            this.updateRefundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRefundButton.Location = new System.Drawing.Point(33, 214);
            this.updateRefundButton.Name = "updateRefundButton";
            this.updateRefundButton.Size = new System.Drawing.Size(243, 57);
            this.updateRefundButton.TabIndex = 5;
            this.updateRefundButton.Text = "Update Refund Status";
            this.updateRefundButton.UseVisualStyleBackColor = true;
            this.updateRefundButton.Click += new System.EventHandler(this.updateRefundButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(12, 9);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(223, 46);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1220, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(223, 46);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repairStatusComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.updateRepairStatus);
            this.groupBox1.Location = new System.Drawing.Point(1047, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Repair Status";
            // 
            // repairStatusComboBox
            // 
            this.repairStatusComboBox.FormattingEnabled = true;
            this.repairStatusComboBox.Items.AddRange(new object[] {
            "Two",
            "Three",
            "Four",
            "Five",
            "Six"});
            this.repairStatusComboBox.Location = new System.Drawing.Point(47, 146);
            this.repairStatusComboBox.Name = "repairStatusComboBox";
            this.repairStatusComboBox.Size = new System.Drawing.Size(248, 21);
            this.repairStatusComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Update the Repair Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refundStatusComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.updateRefundButton);
            this.groupBox2.Location = new System.Drawing.Point(89, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(340, 311);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Refund Status";
            // 
            // refundStatusComboBox
            // 
            this.refundStatusComboBox.FormattingEnabled = true;
            this.refundStatusComboBox.Items.AddRange(new object[] {
            "Two",
            "Three",
            "Four",
            "Five"});
            this.refundStatusComboBox.Location = new System.Drawing.Point(33, 146);
            this.refundStatusComboBox.Name = "refundStatusComboBox";
            this.refundStatusComboBox.Size = new System.Drawing.Size(243, 21);
            this.refundStatusComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Update the Refund Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateDeliveryStatusButton);
            this.groupBox3.Controls.Add(this.deliveryComboBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.usernameTextBox);
            this.groupBox3.Controls.Add(this.loadCustomerInformationButton);
            this.groupBox3.Location = new System.Drawing.Point(539, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 311);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Load Information";
            // 
            // updateDeliveryStatusButton
            // 
            this.updateDeliveryStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDeliveryStatusButton.Location = new System.Drawing.Point(106, 248);
            this.updateDeliveryStatusButton.Name = "updateDeliveryStatusButton";
            this.updateDeliveryStatusButton.Size = new System.Drawing.Size(223, 57);
            this.updateDeliveryStatusButton.TabIndex = 16;
            this.updateDeliveryStatusButton.Text = "Update Delivery Status";
            this.updateDeliveryStatusButton.UseVisualStyleBackColor = true;
            this.updateDeliveryStatusButton.Click += new System.EventHandler(this.updateDeliveryStatusButton_Click);
            // 
            // deliveryComboBox
            // 
            this.deliveryComboBox.FormattingEnabled = true;
            this.deliveryComboBox.Items.AddRange(new object[] {
            "Two",
            "Three",
            "Four",
            "Five",
            "Six"});
            this.deliveryComboBox.Location = new System.Drawing.Point(106, 208);
            this.deliveryComboBox.Name = "deliveryComboBox";
            this.deliveryComboBox.Size = new System.Drawing.Size(223, 21);
            this.deliveryComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Please enter Customer Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(106, 72);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(223, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // loadCustomerInformationButton
            // 
            this.loadCustomerInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCustomerInformationButton.Location = new System.Drawing.Point(106, 120);
            this.loadCustomerInformationButton.Name = "loadCustomerInformationButton";
            this.loadCustomerInformationButton.Size = new System.Drawing.Size(223, 57);
            this.loadCustomerInformationButton.TabIndex = 2;
            this.loadCustomerInformationButton.Text = "Load Customer Information";
            this.loadCustomerInformationButton.UseVisualStyleBackColor = true;
            this.loadCustomerInformationButton.Click += new System.EventHandler(this.loadCustomerInformationButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(668, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Customer Orders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1165, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Customer Repairs ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Customer Refunds";
            // 
            // gSEDatabaseDataSet
            // 
            this.gSEDatabaseDataSet.DataSetName = "GSEDatabaseDataSet";
            this.gSEDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataMember = "Purchases";
            this.purchasesBindingSource.DataSource = this.gSEDatabaseDataSet;
            // 
            // purchasesTableAdapter
            // 
            this.purchasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartTableAdapter = null;
            this.tableAdapterManager.CCInformationTableAdapter = null;
            this.tableAdapterManager.ComputerDirectoryTableAdapter = null;
            this.tableAdapterManager.ConsoleDirectoryTableAdapter = null;
            this.tableAdapterManager.CustomerInformationTableAdapter = null;
            this.tableAdapterManager.PurchasesTableAdapter = this.purchasesTableAdapter;
            this.tableAdapterManager.RefundsTableAdapter = this.refundsTableAdapter;
            this.tableAdapterManager.RepairsTableAdapter = this.repairsTableAdapter;
            this.tableAdapterManager.ResetTicketsTableAdapter = null;
            this.tableAdapterManager.TabletDirectorTableAdapter = null;
            this.tableAdapterManager.TelevisionDirectoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GlobalSanicElectronics.GSEDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // refundsTableAdapter
            // 
            this.refundsTableAdapter.ClearBeforeFill = true;
            // 
            // repairsTableAdapter
            // 
            this.repairsTableAdapter.ClearBeforeFill = true;
            // 
            // refundsBindingSource
            // 
            this.refundsBindingSource.DataMember = "Refunds";
            this.refundsBindingSource.DataSource = this.gSEDatabaseDataSet;
            // 
            // repairsBindingSource
            // 
            this.repairsBindingSource.DataMember = "Repairs";
            this.repairsBindingSource.DataSource = this.gSEDatabaseDataSet;
            // 
            // refundsDataGridView
            // 
            this.refundsDataGridView.AutoGenerateColumns = false;
            this.refundsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.refundsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.OrderNumber,
            this.RefundID});
            this.refundsDataGridView.DataSource = this.refundsBindingSource;
            this.refundsDataGridView.Location = new System.Drawing.Point(21, 125);
            this.refundsDataGridView.Name = "refundsDataGridView";
            this.refundsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.refundsDataGridView.Size = new System.Drawing.Size(467, 220);
            this.refundsDataGridView.TabIndex = 27;
            // 
            // repairsDataGridView
            // 
            this.repairsDataGridView.AutoGenerateColumns = false;
            this.repairsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repairsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.RepairID});
            this.repairsDataGridView.DataSource = this.repairsBindingSource;
            this.repairsDataGridView.Location = new System.Drawing.Point(1006, 125);
            this.repairsDataGridView.Name = "repairsDataGridView";
            this.repairsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.repairsDataGridView.Size = new System.Drawing.Size(470, 220);
            this.repairsDataGridView.TabIndex = 27;
            // 
            // purchasesDataGridView
            // 
            this.purchasesDataGridView.AutoGenerateColumns = false;
            this.purchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.PurchaseNumber});
            this.purchasesDataGridView.DataSource = this.purchasesBindingSource;
            this.purchasesDataGridView.Location = new System.Drawing.Point(518, 125);
            this.purchasesDataGridView.Name = "purchasesDataGridView";
            this.purchasesDataGridView.ReadOnly = true;
            this.purchasesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchasesDataGridView.Size = new System.Drawing.Size(445, 220);
            this.purchasesDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Stages";
            this.dataGridViewTextBoxColumn7.HeaderText = "Stages";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // PurchaseNumber
            // 
            this.PurchaseNumber.DataPropertyName = "PurchaseNumber";
            this.PurchaseNumber.HeaderText = "PurchaseNumber";
            this.PurchaseNumber.Name = "PurchaseNumber";
            this.PurchaseNumber.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "RefundStatus";
            this.dataGridViewTextBoxColumn23.HeaderText = "RefundStatus";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn24.HeaderText = "Username";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "OrderNumber";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // RefundID
            // 
            this.RefundID.DataPropertyName = "RefundID";
            this.RefundID.HeaderText = "RefundID";
            this.RefundID.Name = "RefundID";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "RepairStatus";
            this.dataGridViewTextBoxColumn32.HeaderText = "RepairStatus";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn33.HeaderText = "Username";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "OrderNumber";
            this.dataGridViewTextBoxColumn34.HeaderText = "OrderNumber";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // RepairID
            // 
            this.RepairID.DataPropertyName = "RepairID";
            this.RepairID.HeaderText = "RepairID";
            this.RepairID.Name = "RepairID";
            // 
            // EmployeeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 719);
            this.Controls.Add(this.purchasesDataGridView);
            this.Controls.Add(this.repairsDataGridView);
            this.Controls.Add(this.refundsDataGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.genericLabel);
            this.Name = "EmployeeScreenForm";
            this.Text = "EmployeeScreen";
            this.Load += new System.EventHandler(this.EmployeeScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSEDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.Button updateRepairStatus;
        private System.Windows.Forms.Button updateRefundButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button loadCustomerInformationButton;
        private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private GSEDatabaseDataSet gSEDatabaseDataSet;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private GSEDatabaseDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private GSEDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private GSEDatabaseDataSetTableAdapters.RefundsTableAdapter refundsTableAdapter;
        private System.Windows.Forms.BindingSource refundsBindingSource;
        private GSEDatabaseDataSetTableAdapters.RepairsTableAdapter repairsTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.BindingSource repairsBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridView repairsDataGridView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridView refundsDataGridView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox repairStatusComboBox;
        private System.Windows.Forms.ComboBox refundStatusComboBox;
        private System.Windows.Forms.Button updateDeliveryStatusButton;
        private System.Windows.Forms.ComboBox deliveryComboBox;
        private System.Windows.Forms.DataGridView purchasesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefundID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairID;
    }
}