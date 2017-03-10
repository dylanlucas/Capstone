using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace GlobalSanicElectronics
{
    public partial class ReceiptScreen : Form
    {
        public ReceiptScreen()
        {
            InitializeComponent();
        }        
                                                            
        public string username { get; set; }
        public double price { get; set; }
        public string console { get; set; }
        public string computer { get; set; }
        public string tablet { get; set; }
        public string television { get; set; }

        Random orderNumber = new Random();

        double number;
        string email;

        private void ReceiptScreen_Load(object sender, EventArgs e)
        {
            string selectSql = "SELECT Email FROM CustomerInformation WHERE Username= '" + username + "'";
            SqlCommand com = new SqlCommand(selectSql, DatabaseOperations.sqlConnectionLink);

            try
            {
                DatabaseOperations.sqlConnectionLink.Open();

                using (SqlDataReader reader = com.ExecuteReader())
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

            //Update Cart and remove user cart as it has been purchased
            System.Data.SqlClient.SqlCommand updateCart = new System.Data.SqlClient.SqlCommand();
            updateCart.CommandType = System.Data.CommandType.Text;
            updateCart.CommandText = "DELETE FROM Cart WHERE Username= '" + username + "'";

            updateCart.Connection = DatabaseOperations.sqlConnectionLink;
            DatabaseOperations.sqlConnectionLink.Open();
            updateCart.ExecuteNonQuery();
            DatabaseOperations.sqlConnectionLink.Close();


            //Get Order Number with the Random Class
            number = orderNumber.Next();

            //Display the Order Number in the label
            orderNumberDisplayLabel.Text = number.ToString();

            //Update the Purchase table and add the user's Order number to the table
            System.Data.SqlClient.SqlCommand updatePurchases = new System.Data.SqlClient.SqlCommand();
            updatePurchases.CommandType = System.Data.CommandType.Text;
            updatePurchases.CommandText = "INSERT into Purchases (Username, OrderNumber, Computer, Console, Television, Tablet, Price, Stages) VALUES ('" + username + "' , '" + number.ToString() + "' , '" + computer + "' , '" + console + "' , '" + television + "' , '" + tablet + "' , '" + price + "' , '" + "1" + "')";

            updatePurchases.Connection = DatabaseOperations.sqlConnectionLink;
            DatabaseOperations.sqlConnectionLink.Open();
            updatePurchases.ExecuteNonQuery();
            DatabaseOperations.sqlConnectionLink.Close();

            //Way to send user an email with all the purchase information and give them there order number
            var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toAddress = new MailAddress(email, username);
            const string fromPassword = "GSEPassword";
            const string subject = "Thank you for your purchase from Global Sanic Electronics!";
            string body = "Hello " + username + " thank you for your recent purchase from Global Sanic Electronics!" + "\n\n" +
                "Here is all the information for your recent purchase!" + "\n\n" +
                "Price = $" + price + "\n" +
                "Order number = " + number + "\n" +
                "Console in order? " + console + "\n" +
                "Computer in order? " + computer + "\n" +
                "Tablet in order? " + tablet + "\n" +
                "Television in order? " + television + "\n\n" +
                "Once again, thank you for your purchase from Global Sanic Electronics!";

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

            //Go to the MainApplication since the user has successfully logged in and created there account
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.mainApplicationUsername = username;
            mainApplicationForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application out when the user clicks Exit
            this.Close();
        }
    }
}
