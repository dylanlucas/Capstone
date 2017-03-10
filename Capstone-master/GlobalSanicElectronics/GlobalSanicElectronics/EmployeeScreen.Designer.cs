namespace GlobalSanicElectronics
{
    partial class EmployeeScreen
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
            this.refundNumberInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repairNumberInputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.repairStatusUpdateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refundStatusUpdateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.purchasesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSEDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataGridView)).BeginInit();
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
            this.updateRepairStatus.Location = new System.Drawing.Point(47, 259);
            this.updateRepairStatus.Name = "updateRepairStatus";
            this.updateRepairStatus.Size = new System.Drawing.Size(223, 46);
            this.updateRepairStatus.TabIndex = 4;
            this.updateRepairStatus.Text = "Update Repair Status";
            this.updateRepairStatus.UseVisualStyleBackColor = true;
            this.updateRepairStatus.Click += new System.EventHandler(this.updateRepairStatus_Click);
            // 
            // updateRefundButton
            // 
            this.updateRefundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRefundButton.Location = new System.Drawing.Point(67, 259);
            this.updateRefundButton.Name = "updateRefundButton";
            this.updateRefundButton.Size = new System.Drawing.Size(223, 46);
            this.updateRefundButton.TabIndex = 7;
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
            this.logOutButton.TabIndex = 8;
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
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refundNumberInputTextBox
            // 
            this.refundNumberInputTextBox.Location = new System.Drawing.Point(47, 84);
            this.refundNumberInputTextBox.Name = "refundNumberInputTextBox";
            this.refundNumberInputTextBox.Size = new System.Drawing.Size(243, 20);
            this.refundNumberInputTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please enter Repair Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please enter Refund Numberr";
            // 
            // repairNumberInputTextBox
            // 
            this.repairNumberInputTextBox.Location = new System.Drawing.Point(34, 84);
            this.repairNumberInputTextBox.Name = "repairNumberInputTextBox";
            this.repairNumberInputTextBox.Size = new System.Drawing.Size(248, 20);
            this.repairNumberInputTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.repairStatusUpdateTextBox);
            this.groupBox1.Controls.Add(this.updateRepairStatus);
            this.groupBox1.Controls.Add(this.repairNumberInputTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(66, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Repair Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter in Repair Status Update";
            // 
            // repairStatusUpdateTextBox
            // 
            this.repairStatusUpdateTextBox.Location = new System.Drawing.Point(34, 182);
            this.repairStatusUpdateTextBox.Multiline = true;
            this.repairStatusUpdateTextBox.Name = "repairStatusUpdateTextBox";
            this.repairStatusUpdateTextBox.Size = new System.Drawing.Size(248, 58);
            this.repairStatusUpdateTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refundStatusUpdateTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.updateRefundButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.refundNumberInputTextBox);
            this.groupBox2.Location = new System.Drawing.Point(1047, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(340, 311);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Refund Status";
            // 
            // refundStatusUpdateTextBox
            // 
            this.refundStatusUpdateTextBox.Location = new System.Drawing.Point(47, 171);
            this.refundStatusUpdateTextBox.Multiline = true;
            this.refundStatusUpdateTextBox.Name = "refundStatusUpdateTextBox";
            this.refundStatusUpdateTextBox.Size = new System.Drawing.Size(254, 58);
            this.refundStatusUpdateTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter in Refund Status Update";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(512, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 311);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Repair Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Please enter Customer Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(117, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 57);
            this.button2.TabIndex = 16;
            this.button2.Text = "Load Customer Information";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Customer Orders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1145, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Customer Repairs ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(636, 102);
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
            this.tableAdapterManager.ComputerDirectoryTableAdapter = null;
            this.tableAdapterManager.ConsoleDirectoryTableAdapter = null;
            this.tableAdapterManager.CustomerInformationTableAdapter = null;
            this.tableAdapterManager.PurchasesTableAdapter = this.purchasesTableAdapter;
            this.tableAdapterManager.RefundsTableAdapter = this.refundsTableAdapter;
            this.tableAdapterManager.RepairsTableAdapter = this.repairsTableAdapter;
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
            // purchasesDataGridView
            // 
            this.purchasesDataGridView.AutoGenerateColumns = false;
            this.purchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.purchasesDataGridView.DataSource = this.purchasesBindingSource;
            this.purchasesDataGridView.Location = new System.Drawing.Point(12, 125);
            this.purchasesDataGridView.Name = "purchasesDataGridView";
            this.purchasesDataGridView.Size = new System.Drawing.Size(431, 220);
            this.purchasesDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PurchaseNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "PurchaseNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "OrderNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Computer";
            this.dataGridViewTextBoxColumn4.HeaderText = "Computer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Console";
            this.dataGridViewTextBoxColumn5.HeaderText = "Console";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Television";
            this.dataGridViewTextBoxColumn13.HeaderText = "Television";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Tablet";
            this.dataGridViewTextBoxColumn18.HeaderText = "Tablet";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn19.HeaderText = "Price";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Stages";
            this.dataGridViewTextBoxColumn20.HeaderText = "Stages";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // refundsDataGridView
            // 
            this.refundsDataGridView.AutoGenerateColumns = false;
            this.refundsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.refundsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.refundsDataGridView.DataSource = this.refundsBindingSource;
            this.refundsDataGridView.Location = new System.Drawing.Point(495, 125);
            this.refundsDataGridView.Name = "refundsDataGridView";
            this.refundsDataGridView.Size = new System.Drawing.Size(472, 220);
            this.refundsDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "RefundNumber";
            this.dataGridViewTextBoxColumn21.HeaderText = "RefundNumber";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn22.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn23.HeaderText = "ItemDescription";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "RefundStatus";
            this.dataGridViewTextBoxColumn24.HeaderText = "RefundStatus";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn25.HeaderText = "Username";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // repairsDataGridView
            // 
            this.repairsDataGridView.AutoGenerateColumns = false;
            this.repairsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repairsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            this.repairsDataGridView.DataSource = this.repairsBindingSource;
            this.repairsDataGridView.Location = new System.Drawing.Point(1012, 125);
            this.repairsDataGridView.Name = "repairsDataGridView";
            this.repairsDataGridView.Size = new System.Drawing.Size(415, 220);
            this.repairsDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "RepairNumber";
            this.dataGridViewTextBoxColumn26.HeaderText = "RepairNumber";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn27.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn28.HeaderText = "ItemDescription";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "RepairStatus";
            this.dataGridViewTextBoxColumn29.HeaderText = "RepairStatus";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn30.HeaderText = "Username";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // EmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 711);
            this.Controls.Add(this.repairsDataGridView);
            this.Controls.Add(this.refundsDataGridView);
            this.Controls.Add(this.purchasesDataGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.genericLabel);
            this.Name = "EmployeeScreen";
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
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.Button updateRepairStatus;
        private System.Windows.Forms.Button updateRefundButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox refundNumberInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox repairNumberInputTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repairStatusUpdateTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox refundStatusUpdateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private GSEDatabaseDataSet gSEDatabaseDataSet;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private GSEDatabaseDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private GSEDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GSEDatabaseDataSetTableAdapters.RefundsTableAdapter refundsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.BindingSource refundsBindingSource;
        private GSEDatabaseDataSetTableAdapters.RepairsTableAdapter repairsTableAdapter;
        private System.Windows.Forms.BindingSource repairsBindingSource;
        private System.Windows.Forms.DataGridView purchasesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridView refundsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridView repairsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
    }
}