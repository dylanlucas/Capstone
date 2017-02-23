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
            this.genericLabel = new System.Windows.Forms.Label();
            this.myItemsTextBox = new System.Windows.Forms.TextBox();
            this.requestRepairButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
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
            // myItemsTextBox
            // 
            this.myItemsTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.myItemsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myItemsTextBox.Location = new System.Drawing.Point(37, 134);
            this.myItemsTextBox.Multiline = true;
            this.myItemsTextBox.Name = "myItemsTextBox";
            this.myItemsTextBox.ReadOnly = true;
            this.myItemsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.myItemsTextBox.Size = new System.Drawing.Size(344, 197);
            this.myItemsTextBox.TabIndex = 8;
            this.myItemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // RequestRepairScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 436);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.requestRepairButton);
            this.Controls.Add(this.myItemsTextBox);
            this.Controls.Add(this.genericLabel);
            this.Name = "RequestRepairScreen";
            this.Text = "RequestRepairScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.TextBox myItemsTextBox;
        private System.Windows.Forms.Button requestRepairButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label usernameLabel;
    }
}