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
            string salt = "WquZ023E";

            var bytes = new UTF8Encoding().GetBytes(salt + passwordTokenTextBox.Text);               
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }

            string passHash = Convert.ToBase64String(hashBytes);

            bool verifyToken;

            //Check for password Token
            SqlCommand cmd = new SqlCommand("SELECT * From ResetTickets WHERE Username = @Username AND tokenHash = @Password AND DATEADD(minute, 15, expirationDate) > GETDATE();");
            cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@Password", passHash);
            cmd.Connection = DatabaseOperations.sqlConnectionLink;
            DatabaseOperations.sqlConnectionLink.Open();
            verifyToken = cmd.ExecuteReader().HasRows;           
            DatabaseOperations.sqlConnectionLink.Close();

            if (verifyToken)
            {
                label2.Visible = true;
                newPasswordTextBox.Visible = true;
                changeButton.Visible = true;

                string remove = "DELETE FROM ResetTickets WHERE Username= '" + usernameTextBox.Text + "'";
                SqlCommand removeAndUpdateCommand = new SqlCommand(remove, DatabaseOperations.sqlConnectionLink);
                DatabaseOperations.sqlConnectionLink.Open();
                removeAndUpdateCommand.ExecuteNonQuery();
                DatabaseOperations.sqlConnectionLink.Close();
            }
            else
            {
                MessageBox.Show("Token is incorrect.");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //Change the password in CustomerInformation Table

            string salt = "WquZ012C";

            var bytes = new UTF8Encoding().GetBytes(salt + newPasswordTextBox.Text);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }

            string passHash = Convert.ToBase64String(hashBytes);
            SqlCommand cmd = new SqlCommand("UPDATE CustomerInformation SET Password = @Password WHERE Username = @Username; DELETE FROM ResetTickets WHERE Username = @Username");
            cmd.Parameters.AddWithValue("@Password", passHash);
            cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
            cmd.Connection = DatabaseOperations.sqlConnectionLink;
            DatabaseOperations.sqlConnectionLink.Open();
            cmd.ExecuteNonQuery();
            DatabaseOperations.sqlConnectionLink.Close();

            MessageBox.Show("Password has been updated!");
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
