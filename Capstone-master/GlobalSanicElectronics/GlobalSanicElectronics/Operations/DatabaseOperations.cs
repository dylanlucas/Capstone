using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    static public class DatabaseOperations
    {
        static public SqlConnection 
                sqlConnectionLink = new SqlConnection(ConfigurationManager.ConnectionStrings["GlobalSanicElectronics"].ConnectionString);

        public static string GetUserEmail(string username)
        {           
            using (System.Data.SqlClient.SqlCommand selectEmailCommand = new System.Data.SqlClient.SqlCommand())
            {
                string email = "";

                selectEmailCommand.CommandText = "SELECT Email FROM CustomerInformation WHERE Username Like @Username";
                selectEmailCommand.Parameters.AddWithValue("@Username", username);
                selectEmailCommand.Connection = DatabaseOperations.sqlConnectionLink;

                try
                {
                    selectEmailCommand.Connection.Open();

                    using (SqlDataReader reader = selectEmailCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            email = (reader["Email"].ToString());
                        }
                    }
                }
                finally
                {
                    selectEmailCommand.Connection.Close();
                }

                return email;
            }
        }

        public static bool ForgotPasswordEmail(TextBox usernameTextBox, TextBox emailTextBox)
        {
            using (SqlCommand forgotPassword = new SqlCommand())
            {
                forgotPassword.CommandText = "SELECT Email FROM CustomerInformation WHERE Username LIKE @Username and Email = @Email";
                forgotPassword.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                forgotPassword.Parameters.AddWithValue("@Email", emailTextBox.Text);
                forgotPassword.Connection = DatabaseOperations.sqlConnectionLink;
                DatabaseOperations.sqlConnectionLink.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(forgotPassword);
                da.Fill(ds);
                DatabaseOperations.sqlConnectionLink.Close();

                bool emailVerified = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                return emailVerified;
            }
        }

        public static double ForgotPassword(TextBox usernameTextBox)
        {
            double temporaryPassword;

            Random tempPassword = new Random();

            temporaryPassword = tempPassword.Next();

            string salt = "WquZ023E";

            var bytes = new UTF8Encoding().GetBytes(salt + temporaryPassword);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }

            string passHash = Convert.ToBase64String(hashBytes);

            SqlCommand createTempPassCommand = new SqlCommand();
            createTempPassCommand.CommandType = CommandType.Text;
            createTempPassCommand.CommandText = "INSERT into ResetTickets (Username, tokenHash, expirationDate) VALUES ('" + usernameTextBox.Text + "' , '" + passHash + "' , GETDATE())";
            createTempPassCommand.Connection = DatabaseOperations.sqlConnectionLink;

            DatabaseOperations.sqlConnectionLink.Open();
            createTempPassCommand.ExecuteNonQuery();
            DatabaseOperations.sqlConnectionLink.Close();

            return temporaryPassword;
        }

        public static bool ChangePassword(TextBox passwordTokenTextBox, TextBox usernameTextBox)
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

            return verifyToken;
        }

        public static void CheckToken(Label label2, TextBox newPasswordTextBox, Button changeButton, TextBox usernameTextBox)
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

        public static void UserChangesPassword(TextBox newPasswordTextBox, TextBox usernameTextBox)
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

        public static void UpdateDeliveryStatus(ComboBox deliveryComboBox, TextBox usernameTextBox, string email)
        {
            //Variable to hold what is in the combo box
            string deliveryStatus = deliveryComboBox.Text;

            SqlCommand updateRepairCommand = new SqlCommand();
            updateRepairCommand.CommandType = CommandType.Text;
            updateRepairCommand.CommandText = "UPDATE Purchases SET Stages= '" + deliveryComboBox.SelectedItem + "' WHERE Username= '" + usernameTextBox.Text + "'";
            updateRepairCommand.Connection = DatabaseOperations.sqlConnectionLink;
            DatabaseOperations.sqlConnectionLink.Open();
            updateRepairCommand.ExecuteNonQuery();
            DatabaseOperations.sqlConnectionLink.Close();

            MessageBox.Show("Delivery Status has been updated");

            //Get the customers email
            string selectEmailSQL = "SELECT Email FROM CustomerInformation Where Username= '" + usernameTextBox.Text + "'";
            SqlCommand command = new SqlCommand(selectEmailSQL, DatabaseOperations.sqlConnectionLink);

            try
            {
                DatabaseOperations.sqlConnectionLink.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        email = (reader["Email"].ToString());
                    }
                }
            }
            finally
            {
                DatabaseOperations.sqlConnectionLink.Close();
            }
        }

        public static void LoadCustomerInformation(TextBox usernameTextBox, DataGridView purchasesDataGridView, DataGridView refundsDataGridView, DataGridView repairsDataGridView)
        {
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("No username entered");
            }
            else
            {
                foreach (DataGridViewRow row in purchasesDataGridView.SelectedRows)
                {
                    //To hold information about the purchase table and input it into the Repair table in the database
                    string username = row.Cells[0].Value.ToString();
                    string orderNumber = row.Cells[1].Value.ToString();
                    string price = row.Cells[2].Value.ToString();
                    string stages = row.Cells[3].Value.ToString();

                    //Update and Refresh the datagridviews for Repair & Refund tables
                    var select = "SELECT * FROM Refunds WHERE Username= '" + usernameTextBox.Text + "'" +
                        "SELECT * FROM Repairs WHERE Username= '" + usernameTextBox.Text + "'";
                    var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    refundsDataGridView.DataSource = ds.Tables[0];
                    repairsDataGridView.DataSource = ds.Tables[1];
                }
            }
        }        
    }
}
