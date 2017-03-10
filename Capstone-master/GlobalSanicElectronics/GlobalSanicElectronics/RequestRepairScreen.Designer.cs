namespace GlobalSanicElectronics
{
    partial class RequestRepairScreen
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
            this.requestRepairButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.gSEDatabaseDataSet = new GlobalSanicElectronics.GSEDatabaseDataSet();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesTableAdapter = new GlobalSanicElectronics.GSEDatabaseDataSetTableAdapters.PurchasesTableAdapter();
            this.tableAdapterManager = new GlobalSanicElectronics.GSEDatabaseDataSetTableAdapters.TableAdapterManager();
            this.purchasesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gSEDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // genericLabel
            // 
            this.genericLabel.AutoSize = true;
            this.genericLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericLabel.Location = new System.Drawing.Point(49, 28);
            this.genericLabel.Name = "genericLabel";
            this.genericLabel.Size = new System.Drawing.Size(332, 31);
            this.genericLabel.TabIndex = 7;
            this.genericLabel.Text = "Global Sanic Electronics";
            // 
            // requestRepairButton
            // 
            this.requestRepairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestRepairButton.Location = new System.Drawing.Point(37, 361);
            this.requestRepairButton.Name = "requestRepairButton";
            this.requestRepairButton.Size = new System.Drawing.Size(126, 53);
            this.requestRepairButton.TabIndex = 1;
            this.requestRepairButton.Text = "Request Repair";
            this.requestRepairButton.UseVisualStyleBackColor = true;
            this.requestRepairButton.Click += new System.EventHandler(this.requestRepairButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(255, 361);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(126, 53);
            this.goBackButton.TabIndex = 2;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(170, 96);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 20);
            this.usernameLabel.TabIndex = 42;
            this.usernameLabel.Text = "My Items";
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
            this.tableAdapterManager.RefundsTableAdapter = null;
            this.tableAdapterManager.RepairsTableAdapter = null;
            this.tableAdapterManager.TabletDirectorTableAdapter = null;
            this.tableAdapterManager.TelevisionDirectoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GlobalSanicElectronics.GSEDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.purchasesDataGridView.DataSource = this.purchasesBindingSource;
            this.purchasesDataGridView.Location = new System.Drawing.Point(37, 119);
            this.purchasesDataGridView.Name = "purchasesDataGridView";
            this.purchasesDataGridView.Size = new System.Drawing.Size(344, 220);
            this.purchasesDataGridView.TabIndex = 43;
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Television";
            this.dataGridViewTextBoxColumn6.HeaderText = "Television";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Tablet";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tablet";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Stages";
            this.dataGridViewTextBoxColumn9.HeaderText = "Stages";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // RequestRepairScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 463);
            this.Controls.Add(this.purchasesDataGridView);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.requestRepairButton);
            this.Controls.Add(this.genericLabel);
            this.Name = "RequestRepairScreen";
            this.Text = "RequestRepairScreen";
            this.Load += new System.EventHandler(this.RequestRepairScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gSEDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.Button requestRepairButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label usernameLabel;
        private GSEDatabaseDataSet gSEDatabaseDataSet;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private GSEDatabaseDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private GSEDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView purchasesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}