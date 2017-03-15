using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool verifyToken;

            if (verifyToken = DatabaseOperations.ChangePassword(passwordTokenTextBox, usernameTextBox))
            {
                DatabaseOperations.CheckToken(label2, newPasswordTextBox, changeButton, usernameTextBox);
            }
            else
            {
                MessageBox.Show("Token is incorrect.");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            DatabaseOperations.UserChangesPassword(newPasswordTextBox, usernameTextBox);
        }

        private void ChangePasswordcs_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            LoginScreen loginScreenForm = new LoginScreen();
            loginScreenForm.Show();
        }
    }
}
