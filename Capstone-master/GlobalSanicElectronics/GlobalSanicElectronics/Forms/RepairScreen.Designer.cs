namespace GlobalSanicElectronics
{
    partial class RepairScreen
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
            this.genericLabel = new System.Windows.Forms.Label();
            this.requestRepairButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.repairStatusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genericLabel
            // 
            this.genericLabel.AutoSize = true;
            this.genericLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericLabel.Location = new System.Drawing.Point(34, 31);
            this.genericLabel.Name = "genericLabel";
            this.genericLabel.Size = new System.Drawing.Size(332, 31);
            this.genericLabel.TabIndex = 6;
            this.genericLabel.Text = "Global Sanic Electronics";
            // 
            // requestRepairButton
            // 
            this.requestRepairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestRepairButton.Location = new System.Drawing.Point(129, 104);
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
            this.goBackButton.Location = new System.Drawing.Point(129, 299);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(126, 53);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // repairStatusButton
            // 
            this.repairStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairStatusButton.Location = new System.Drawing.Point(129, 200);
            this.repairStatusButton.Name = "repairStatusButton";
            this.repairStatusButton.Size = new System.Drawing.Size(126, 53);
            this.repairStatusButton.TabIndex = 2;
            this.repairStatusButton.Text = "Repair Status";
            this.repairStatusButton.UseVisualStyleBackColor = true;
            this.repairStatusButton.Click += new System.EventHandler(this.repairStatusButton_Click);
            // 
            // RepairScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 401);
            this.Controls.Add(this.repairStatusButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.requestRepairButton);
            this.Controls.Add(this.genericLabel);
            this.Name = "RepairScreen";
            this.Text = "RepairScreen";
            this.Load += new System.EventHandler(this.RepairScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.Button requestRepairButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button repairStatusButton;
    }
}