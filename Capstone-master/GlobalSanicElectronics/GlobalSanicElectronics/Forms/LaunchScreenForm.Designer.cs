namespace GlobalSanicElectronics
{
    partial class LaunchScreenForm
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
            this.accCreateLabel = new System.Windows.Forms.Label();
            this.ORLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.accCreateButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genericLabel
            // 
            this.genericLabel.AutoSize = true;
            this.genericLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericLabel.Location = new System.Drawing.Point(280, 9);
            this.genericLabel.Name = "genericLabel";
            this.genericLabel.Size = new System.Drawing.Size(332, 31);
            this.genericLabel.TabIndex = 0;
            this.genericLabel.Text = "Global Sanic Electronics";
            // 
            // accCreateLabel
            // 
            this.accCreateLabel.AutoSize = true;
            this.accCreateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accCreateLabel.Location = new System.Drawing.Point(56, 172);
            this.accCreateLabel.Name = "accCreateLabel";
            this.accCreateLabel.Size = new System.Drawing.Size(207, 25);
            this.accCreateLabel.TabIndex = 1;
            this.accCreateLabel.Text = "Create an Account";
            // 
            // ORLabel
            // 
            this.ORLabel.AutoSize = true;
            this.ORLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORLabel.Location = new System.Drawing.Point(421, 172);
            this.ORLabel.Name = "ORLabel";
            this.ORLabel.Size = new System.Drawing.Size(45, 25);
            this.ORLabel.TabIndex = 2;
            this.ORLabel.Text = "OR";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(674, 172);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(70, 25);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login";
            // 
            // accCreateButton
            // 
            this.accCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accCreateButton.Location = new System.Drawing.Point(61, 244);
            this.accCreateButton.Name = "accCreateButton";
            this.accCreateButton.Size = new System.Drawing.Size(202, 50);
            this.accCreateButton.TabIndex = 1;
            this.accCreateButton.Text = "Account Creation";
            this.accCreateButton.UseVisualStyleBackColor = true;
            this.accCreateButton.Click += new System.EventHandler(this.accCreateButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(608, 244);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(202, 50);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "User Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(0, 365);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(886, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LaunchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 405);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.accCreateButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.ORLabel);
            this.Controls.Add(this.accCreateLabel);
            this.Controls.Add(this.genericLabel);
            this.Name = "LaunchScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LaunchScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.Label accCreateLabel;
        private System.Windows.Forms.Label ORLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button accCreateButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
    }
}

