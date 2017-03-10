using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GlobalSanicElectronics
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        double temporaryPassword;

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Check for Email
            SqlCommand cmd = new SqlCommand("SELECT Email from CustomerInformation WHERE Username LIKE @Username AND Email = @Email");
            cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
            cmd.Connection = DatabaseOperations.sqlConnectionLink;
            DatabaseOperations.sqlConnectionLink.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            DatabaseOperations.sqlConnectionLink.Close();

            bool emailVerified = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            if (emailVerified)
            {
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

                //Way to send user an email with all account information and confirm that there account is created.
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(emailTextBox.Text, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Password Reset";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Here is your temporary password : " + temporaryPassword + "\n\n" +
                    "In order to reset your password, you must log in with that password and follow the on screen instructions followed";

                //Area to establish a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                MessageBox.Show("Information on what to do to recover your password has been sent to the address");
            }
            else
            {
                MessageBox.Show("Information on what to do to recover your password has been sent to the address");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            LoginScreen loginScreenForm = new LoginScreen();
            loginScreenForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = confirmButton;
        }
    }
}
