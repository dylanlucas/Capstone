namespace GlobalSanicElectronics
{
    partial class OrderScreenPartTwo
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.confirmPurchaseButton = new System.Windows.Forms.Button();
            this.shippingGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmShippingInformationButton = new System.Windows.Forms.Button();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.streetAddLabel = new System.Windows.Forms.Label();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCombBox = new System.Windows.Forms.ComboBox();
            this.confirmPaymentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalPaymentDisplayLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shippingSpeedGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmShippingSpeedButton = new System.Windows.Forms.Button();
            this.shippingTwoRadioButton = new System.Windows.Forms.RadioButton();
            this.shippingOneRadioButton = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.shippingGroupBox.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.shippingSpeedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // genericLabel
            // 
            this.genericLabel.AutoSize = true;
            this.genericLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericLabel.Location = new System.Drawing.Point(504, 30);
            this.genericLabel.Name = "genericLabel";
            this.genericLabel.Size = new System.Drawing.Size(332, 31);
            this.genericLabel.TabIndex = 5;
            this.genericLabel.Text = "Global Sanic Electronics";
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(982, 637);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(108, 36);
            this.goBackButton.TabIndex = 11;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // confirmPurchaseButton
            // 
            this.confirmPurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPurchaseButton.Location = new System.Drawing.Point(1112, 637);
            this.confirmPurchaseButton.Name = "confirmPurchaseButton";
            this.confirmPurchaseButton.Size = new System.Drawing.Size(186, 36);
            this.confirmPurchaseButton.TabIndex = 12;
            this.confirmPurchaseButton.Text = "Confirm Purchase";
            this.confirmPurchaseButton.UseVisualStyleBackColor = true;
            this.confirmPurchaseButton.Click += new System.EventHandler(this.confirmPurchaseButton_Click);
            // 
            // shippingGroupBox
            // 
            this.shippingGroupBox.Controls.Add(this.confirmShippingInformationButton);
            this.shippingGroupBox.Controls.Add(this.zipTextBox);
            this.shippingGroupBox.Controls.Add(this.zipLabel);
            this.shippingGroupBox.Controls.Add(this.stateTextBox);
            this.shippingGroupBox.Controls.Add(this.stateLabel);
            this.shippingGroupBox.Controls.Add(this.cityTextBox);
            this.shippingGroupBox.Controls.Add(this.cityLabel);
            this.shippingGroupBox.Controls.Add(this.addressTextBox);
            this.shippingGroupBox.Controls.Add(this.streetAddLabel);
            this.shippingGroupBox.Location = new System.Drawing.Point(44, 98);
            this.shippingGroupBox.Name = "shippingGroupBox";
            this.shippingGroupBox.Size = new System.Drawing.Size(560, 359);
            this.shippingGroupBox.TabIndex = 8;
            this.shippingGroupBox.TabStop = false;
            this.shippingGroupBox.Text = "Shipping Information";
            // 
            // confirmShippingInformationButton
            // 
            this.confirmShippingInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmShippingInformationButton.Location = new System.Drawing.Point(139, 299);
            this.confirmShippingInformationButton.Name = "confirmShippingInformationButton";
            this.confirmShippingInformationButton.Size = new System.Drawing.Size(258, 36);
            this.confirmShippingInformationButton.TabIndex = 5;
            this.confirmShippingInformationButton.Text = "Confirm Shipping Information";
            this.confirmShippingInformationButton.UseVisualStyleBackColor = true;
            this.confirmShippingInformationButton.Click += new System.EventHandler(this.confirmShippingInformationButton_Click);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(350, 247);
            this.zipTextBox.MaxLength = 5;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(170, 20);
            this.zipTextBox.TabIndex = 4;
            this.zipTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipTextBox_Validating);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(31, 247);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(44, 20);
            this.zipLabel.TabIndex = 13;
            this.zipLabel.Text = "Zip :";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(350, 189);
            this.stateTextBox.MaxLength = 2;
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(170, 20);
            this.stateTextBox.TabIndex = 3;
            this.stateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateTextBox_Validating);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(31, 189);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(63, 20);
            this.stateLabel.TabIndex = 11;
            this.stateLabel.Text = "State :";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(350, 134);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(170, 20);
            this.cityTextBox.TabIndex = 2;
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityTextBox_Validating);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(31, 134);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(49, 20);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City :";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(350, 74);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(170, 20);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTextBox_Validating);
            // 
            // streetAddLabel
            // 
            this.streetAddLabel.AutoSize = true;
            this.streetAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetAddLabel.Location = new System.Drawing.Point(31, 74);
            this.streetAddLabel.Name = "streetAddLabel";
            this.streetAddLabel.Size = new System.Drawing.Size(140, 20);
            this.streetAddLabel.TabIndex = 7;
            this.streetAddLabel.Text = "Street Address :";
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.label5);
            this.paymentGroupBox.Controls.Add(this.yearComboBox);
            this.paymentGroupBox.Controls.Add(this.label1);
            this.paymentGroupBox.Controls.Add(this.monthCombBox);
            this.paymentGroupBox.Controls.Add(this.confirmPaymentButton);
            this.paymentGroupBox.Controls.Add(this.label2);
            this.paymentGroupBox.Controls.Add(this.cardNumberTextBox);
            this.paymentGroupBox.Controls.Add(this.label3);
            this.paymentGroupBox.Controls.Add(this.nameTextBox);
            this.paymentGroupBox.Controls.Add(this.label4);
            this.paymentGroupBox.Location = new System.Drawing.Point(680, 98);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(560, 335);
            this.paymentGroupBox.TabIndex = 15;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Year";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(350, 227);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(170, 21);
            this.yearComboBox.TabIndex = 9;
            this.yearComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.yearComboBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Month";
            // 
            // monthCombBox
            // 
            this.monthCombBox.FormattingEnabled = true;
            this.monthCombBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthCombBox.Location = new System.Drawing.Point(350, 200);
            this.monthCombBox.Name = "monthCombBox";
            this.monthCombBox.Size = new System.Drawing.Size(170, 21);
            this.monthCombBox.TabIndex = 8;
            this.monthCombBox.Validating += new System.ComponentModel.CancelEventHandler(this.monthCombBox_Validating);
            // 
            // confirmPaymentButton
            // 
            this.confirmPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPaymentButton.Location = new System.Drawing.Point(150, 284);
            this.confirmPaymentButton.Name = "confirmPaymentButton";
            this.confirmPaymentButton.Size = new System.Drawing.Size(258, 36);
            this.confirmPaymentButton.TabIndex = 10;
            this.confirmPaymentButton.Text = "Confirm Payment Information";
            this.confirmPaymentButton.UseVisualStyleBackColor = true;
            this.confirmPaymentButton.Click += new System.EventHandler(this.confirmPaymentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Expiration Date :";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(350, 134);
            this.cardNumberTextBox.MaxLength = 19;
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(170, 20);
            this.cardNumberTextBox.TabIndex = 7;
            this.cardNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardNumberTextBox_KeyDown);
            this.cardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardNumberTextBox_KeyPress);
            this.cardNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cardNumberTextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Card Number :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(350, 74);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name on Card :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalPaymentDisplayLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(680, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 165);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Final Bill";
            // 
            // totalPaymentDisplayLabel
            // 
            this.totalPaymentDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPaymentDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPaymentDisplayLabel.Location = new System.Drawing.Point(337, 62);
            this.totalPaymentDisplayLabel.Name = "totalPaymentDisplayLabel";
            this.totalPaymentDisplayLabel.Size = new System.Drawing.Size(168, 54);
            this.totalPaymentDisplayLabel.TabIndex = 11;
            this.totalPaymentDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Payment :";
            // 
            // shippingSpeedGroupBox
            // 
            this.shippingSpeedGroupBox.Controls.Add(this.confirmShippingSpeedButton);
            this.shippingSpeedGroupBox.Controls.Add(this.shippingTwoRadioButton);
            this.shippingSpeedGroupBox.Controls.Add(this.shippingOneRadioButton);
            this.shippingSpeedGroupBox.Location = new System.Drawing.Point(44, 500);
            this.shippingSpeedGroupBox.Name = "shippingSpeedGroupBox";
            this.shippingSpeedGroupBox.Size = new System.Drawing.Size(560, 152);
            this.shippingSpeedGroupBox.TabIndex = 14;
            this.shippingSpeedGroupBox.TabStop = false;
            this.shippingSpeedGroupBox.Text = "Shipping Speed";
            // 
            // confirmShippingSpeedButton
            // 
            this.confirmShippingSpeedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmShippingSpeedButton.Location = new System.Drawing.Point(139, 98);
            this.confirmShippingSpeedButton.Name = "confirmShippingSpeedButton";
            this.confirmShippingSpeedButton.Size = new System.Drawing.Size(258, 36);
            this.confirmShippingSpeedButton.TabIndex = 14;
            this.confirmShippingSpeedButton.Text = "Confirm Shipping Speed";
            this.confirmShippingSpeedButton.UseVisualStyleBackColor = true;
            this.confirmShippingSpeedButton.Click += new System.EventHandler(this.confirmShippingSpeedButton_Click);
            // 
            // shippingTwoRadioButton
            // 
            this.shippingTwoRadioButton.AutoSize = true;
            this.shippingTwoRadioButton.Location = new System.Drawing.Point(350, 50);
            this.shippingTwoRadioButton.Name = "shippingTwoRadioButton";
            this.shippingTwoRadioButton.Size = new System.Drawing.Size(143, 17);
            this.shippingTwoRadioButton.TabIndex = 50;
            this.shippingTwoRadioButton.Text = "Standard Shipping FREE";
            this.shippingTwoRadioButton.UseVisualStyleBackColor = true;
            // 
            // shippingOneRadioButton
            // 
            this.shippingOneRadioButton.AutoSize = true;
            this.shippingOneRadioButton.Location = new System.Drawing.Point(23, 50);
            this.shippingOneRadioButton.Name = "shippingOneRadioButton";
            this.shippingOneRadioButton.Size = new System.Drawing.Size(167, 17);
            this.shippingOneRadioButton.TabIndex = 49;
            this.shippingOneRadioButton.Text = "Expedited Shipping for $30.00";
            this.shippingOneRadioButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // OrderScreenPartTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 685);
            this.Controls.Add(this.shippingSpeedGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.shippingGroupBox);
            this.Controls.Add(this.confirmPurchaseButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.genericLabel);
            this.Name = "OrderScreenPartTwo";
            this.Text = "OrderScreenPartTwocs";
            this.Load += new System.EventHandler(this.OrderScreenPartTwocs_Load);
            this.shippingGroupBox.ResumeLayout(false);
            this.shippingGroupBox.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.shippingSpeedGroupBox.ResumeLayout(false);
            this.shippingSpeedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button confirmPurchaseButton;
        private System.Windows.Forms.GroupBox shippingGroupBox;
        private System.Windows.Forms.Label streetAddLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Button confirmShippingInformationButton;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.Button confirmPaymentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox monthCombBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalPaymentDisplayLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox shippingSpeedGroupBox;
        private System.Windows.Forms.Button confirmShippingSpeedButton;
        private System.Windows.Forms.RadioButton shippingTwoRadioButton;
        private System.Windows.Forms.RadioButton shippingOneRadioButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}