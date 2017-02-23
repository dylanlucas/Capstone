namespace GlobalSanicElectronics
{
    partial class ReturnScreen
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
            this.requestRefundButton = new System.Windows.Forms.Button();
            this.refundStatusButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genericLabel
            // 
            this.genericLabel.AutoSize = true;
            this.genericLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericLabel.Location = new System.Drawing.Point(43, 30);
            this.genericLabel.Name = "genericLabel";
            this.genericLabel.Size = new System.Drawing.Size(332, 31);
            this.genericLabel.TabIndex = 7;
            this.genericLabel.Text = "Global Sanic Electronics";
            // 
            // requestRefundButton
            // 
            this.requestRefundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestRefundButton.Location = new System.Drawing.Point(143, 117);
            this.requestRefundButton.Name = "requestRefundButton";
            this.requestRefundButton.Size = new System.Drawing.Size(126, 53);
            this.requestRefundButton.TabIndex = 1;
            this.requestRefundButton.Text = "Request Refund";
            this.requestRefundButton.UseVisualStyleBackColor = true;
            this.requestRefundButton.Click += new System.EventHandler(this.requestRefundButton_Click);
            // 
            // refundStatusButton
            // 
            this.refundStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundStatusButton.Location = new System.Drawing.Point(143, 209);
            this.refundStatusButton.Name = "refundStatusButton";
            this.refundStatusButton.Size = new System.Drawing.Size(126, 53);
            this.refundStatusButton.TabIndex = 2;
            this.refundStatusButton.Text = "Refund Status";
            this.refundStatusButton.UseVisualStyleBackColor = true;
            this.refundStatusButton.Click += new System.EventHandler(this.refundStatusButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(143, 299);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(126, 53);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // ReturnScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 416);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.refundStatusButton);
            this.Controls.Add(this.requestRefundButton);
            this.Controls.Add(this.genericLabel);
            this.Name = "ReturnScreen";
            this.Text = "ReturnScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.Button requestRefundButton;
        private System.Windows.Forms.Button refundStatusButton;
        private System.Windows.Forms.Button goBackButton;
    }
}