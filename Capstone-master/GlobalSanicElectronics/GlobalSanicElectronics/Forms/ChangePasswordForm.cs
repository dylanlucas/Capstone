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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Boolean to help make sure that the token that the user enters is valid in the Reset table
            bool verifyToken;

            //Call the DatabaseOperation method to change password and make sure token is correct
            if (verifyToken = DatabaseOperations.ChangePassword(passwordTokenTextBox, usernameTextBox))
            {
                //Pass information for the check to make sure all fields are corresponding with the right information, IE username and password are the same
                //then enable the button and label to let the user to change there password
                DatabaseOperations.CheckToken(label2, newPasswordTextBox, changeButton, usernameTextBox);
            }
            else
            {
                //Let the user know that the token they entered is incorrect
                MessageBox.Show("Token is incorrect.");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //Call the DatabaseOperations method to update the user's new password
            DatabaseOperations.UserChangesPassword(newPasswordTextBox, usernameTextBox, errorProvider);
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

            LoginScreenForm loginScreenForm = new LoginScreenForm();
            loginScreenForm.Show();
        }
    }
}
