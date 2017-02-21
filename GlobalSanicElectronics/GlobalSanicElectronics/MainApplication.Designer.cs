namespace GlobalSanicElectronics
{
    partial class MainApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.returnsButton = new System.Windows.Forms.Button();
            this.toCartButton = new System.Windows.Forms.Button();
            this.cartItemsDisplayLabel = new System.Windows.Forms.Label();
            this.cartItemsTextLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.repairsButton = new System.Windows.Forms.Button();
            this.directoryListBox = new System.Windows.Forms.ListBox();
            this.contactButton = new System.Windows.Forms.Button();
            this.televisionButton = new System.Windows.Forms.Button();
            this.consoleButton = new System.Windows.Forms.Button();
            this.tabletButton = new System.Windows.Forms.Button();
            this.computerButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // genericLabel
            // 
            this.genericLabel.AutoSize = true;
            this.genericLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericLabel.Location = new System.Drawing.Point(361, 9);
            this.genericLabel.Name = "genericLabel";
            this.genericLabel.Size = new System.Drawing.Size(332, 31);
            this.genericLabel.TabIndex = 3;
            this.genericLabel.Text = "Global Sanic Electronics";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderButton);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.addToCartButton);
            this.groupBox1.Controls.Add(this.returnsButton);
            this.groupBox1.Controls.Add(this.toCartButton);
            this.groupBox1.Controls.Add(this.cartItemsDisplayLabel);
            this.groupBox1.Controls.Add(this.cartItemsTextLabel);
            this.groupBox1.Controls.Add(this.logOutButton);
            this.groupBox1.Controls.Add(this.repairsButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 525);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Tools";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(0, 237);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(150, 30);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "Purchase Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(0, 475);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 30);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(0, 127);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(150, 30);
            this.addToCartButton.TabIndex = 1;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // returnsButton
            // 
            this.returnsButton.Location = new System.Drawing.Point(0, 358);
            this.returnsButton.Name = "returnsButton";
            this.returnsButton.Size = new System.Drawing.Size(150, 30);
            this.returnsButton.TabIndex = 5;
            this.returnsButton.Text = "Returns";
            this.returnsButton.UseVisualStyleBackColor = true;
            this.returnsButton.Click += new System.EventHandler(this.returnsButton_Click);
            // 
            // toCartButton
            // 
            this.toCartButton.Location = new System.Drawing.Point(0, 183);
            this.toCartButton.Name = "toCartButton";
            this.toCartButton.Size = new System.Drawing.Size(150, 30);
            this.toCartButton.TabIndex = 2;
            this.toCartButton.Text = "Go to Cart";
            this.toCartButton.UseVisualStyleBackColor = true;
            this.toCartButton.Click += new System.EventHandler(this.toCartButton_Click);
            // 
            // cartItemsDisplayLabel
            // 
            this.cartItemsDisplayLabel.AutoSize = true;
            this.cartItemsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartItemsDisplayLabel.Location = new System.Drawing.Point(15, 68);
            this.cartItemsDisplayLabel.Name = "cartItemsDisplayLabel";
            this.cartItemsDisplayLabel.Size = new System.Drawing.Size(38, 16);
            this.cartItemsDisplayLabel.TabIndex = 8;
            this.cartItemsDisplayLabel.Text = "Cart :";
            // 
            // cartItemsTextLabel
            // 
            this.cartItemsTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartItemsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartItemsTextLabel.Location = new System.Drawing.Point(103, 58);
            this.cartItemsTextLabel.Name = "cartItemsTextLabel";
            this.cartItemsTextLabel.Size = new System.Drawing.Size(41, 36);
            this.cartItemsTextLabel.TabIndex = 9;
            this.cartItemsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(0, 416);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(150, 30);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // repairsButton
            // 
            this.repairsButton.Location = new System.Drawing.Point(0, 298);
            this.repairsButton.Name = "repairsButton";
            this.repairsButton.Size = new System.Drawing.Size(150, 30);
            this.repairsButton.TabIndex = 4;
            this.repairsButton.Text = "Repairs";
            this.repairsButton.UseVisualStyleBackColor = true;
            this.repairsButton.Click += new System.EventHandler(this.repairsButton_Click);
            // 
            // directoryListBox
            // 
            this.directoryListBox.FormattingEnabled = true;
            this.directoryListBox.Location = new System.Drawing.Point(220, 91);
            this.directoryListBox.MultiColumn = true;
            this.directoryListBox.Name = "directoryListBox";
            this.directoryListBox.Size = new System.Drawing.Size(810, 342);
            this.directoryListBox.TabIndex = 11;
            // 
            // contactButton
            // 
            this.contactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactButton.Location = new System.Drawing.Point(949, 12);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(149, 57);
            this.contactButton.TabIndex = 12;
            this.contactButton.Text = "CONTACT";
            this.contactButton.UseVisualStyleBackColor = true;
            this.contactButton.Click += new System.EventHandler(this.contactButton_Click);
            // 
            // televisionButton
            // 
            this.televisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.televisionButton.Location = new System.Drawing.Point(220, 473);
            this.televisionButton.Name = "televisionButton";
            this.televisionButton.Size = new System.Drawing.Size(149, 57);
            this.televisionButton.TabIndex = 8;
            this.televisionButton.Text = "Televisions";
            this.televisionButton.UseVisualStyleBackColor = true;
            this.televisionButton.Click += new System.EventHandler(this.televisionButton_Click);
            // 
            // consoleButton
            // 
            this.consoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleButton.Location = new System.Drawing.Point(441, 473);
            this.consoleButton.Name = "consoleButton";
            this.consoleButton.Size = new System.Drawing.Size(149, 57);
            this.consoleButton.TabIndex = 9;
            this.consoleButton.Text = "Consoles";
            this.consoleButton.UseVisualStyleBackColor = true;
            this.consoleButton.Click += new System.EventHandler(this.consoleButton_Click);
            // 
            // tabletButton
            // 
            this.tabletButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabletButton.Location = new System.Drawing.Point(661, 473);
            this.tabletButton.Name = "tabletButton";
            this.tabletButton.Size = new System.Drawing.Size(149, 57);
            this.tabletButton.TabIndex = 10;
            this.tabletButton.Text = "Tablets";
            this.tabletButton.UseVisualStyleBackColor = true;
            this.tabletButton.Click += new System.EventHandler(this.tabletButton_Click);
            // 
            // computerButton
            // 
            this.computerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerButton.Location = new System.Drawing.Point(881, 473);
            this.computerButton.Name = "computerButton";
            this.computerButton.Size = new System.Drawing.Size(149, 57);
            this.computerButton.TabIndex = 11;
            this.computerButton.Text = "Computers";
            this.computerButton.UseVisualStyleBackColor = true;
            this.computerButton.Click += new System.EventHandler(this.computerButton_Click);
            // 
            // MainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 562);
            this.Controls.Add(this.computerButton);
            this.Controls.Add(this.tabletButton);
            this.Controls.Add(this.consoleButton);
            this.Controls.Add(this.televisionButton);
            this.Controls.Add(this.contactButton);
            this.Controls.Add(this.directoryListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.genericLabel);
            this.Name = "MainApplication";
            this.Text = "MainApplication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button returnsButton;
        private System.Windows.Forms.Button toCartButton;
        private System.Windows.Forms.Label cartItemsDisplayLabel;
        private System.Windows.Forms.Label cartItemsTextLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button repairsButton;
        private System.Windows.Forms.ListBox directoryListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button televisionButton;
        private System.Windows.Forms.Button consoleButton;
        private System.Windows.Forms.Button tabletButton;
        private System.Windows.Forms.Button computerButton;
    }
}