namespace GlobalSanicElectronics
{
    partial class OrderScreen
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
            this.receiptLabel = new System.Windows.Forms.Label();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.myReceiptDisplayLabel = new System.Windows.Forms.Label();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.orderNumberDisplayLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genericLabel
            // 
            this.genericLabel.AutoSize = true;
            this.genericLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericLabel.Location = new System.Drawing.Point(385, 19);
            this.genericLabel.Name = "genericLabel";
            this.genericLabel.Size = new System.Drawing.Size(332, 31);
            this.genericLabel.TabIndex = 4;
            this.genericLabel.Text = "Global Sanic Electronics";
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(104, 115);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(370, 230);
            this.receiptLabel.TabIndex = 46;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderTextBox
            // 
            this.orderTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTextBox.Location = new System.Drawing.Point(589, 188);
            this.orderTextBox.Multiline = true;
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.ReadOnly = true;
            this.orderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.orderTextBox.Size = new System.Drawing.Size(367, 157);
            this.orderTextBox.TabIndex = 45;
            this.orderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myReceiptDisplayLabel
            // 
            this.myReceiptDisplayLabel.AutoSize = true;
            this.myReceiptDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myReceiptDisplayLabel.Location = new System.Drawing.Point(231, 80);
            this.myReceiptDisplayLabel.Name = "myReceiptDisplayLabel";
            this.myReceiptDisplayLabel.Size = new System.Drawing.Size(76, 16);
            this.myReceiptDisplayLabel.TabIndex = 44;
            this.myReceiptDisplayLabel.Text = "My Receipt";
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumberLabel.Location = new System.Drawing.Point(699, 141);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(151, 36);
            this.orderNumberLabel.TabIndex = 43;
            this.orderNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderNumberDisplayLabel
            // 
            this.orderNumberDisplayLabel.AutoSize = true;
            this.orderNumberDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumberDisplayLabel.Location = new System.Drawing.Point(730, 80);
            this.orderNumberDisplayLabel.Name = "orderNumberDisplayLabel";
            this.orderNumberDisplayLabel.Size = new System.Drawing.Size(93, 16);
            this.orderNumberDisplayLabel.TabIndex = 42;
            this.orderNumberDisplayLabel.Text = "Order Number";
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(366, 377);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(108, 36);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(589, 377);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 36);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 425);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.myReceiptDisplayLabel);
            this.Controls.Add(this.orderNumberLabel);
            this.Controls.Add(this.orderNumberDisplayLabel);
            this.Controls.Add(this.genericLabel);
            this.Name = "OrderScreen";
            this.Text = "OrderScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.Label myReceiptDisplayLabel;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label orderNumberDisplayLabel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button exitButton;
    }
}