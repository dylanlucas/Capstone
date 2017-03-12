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

namespace GlobalSanicElectronics
{
    public partial class RequestRefundScreen : Form
    {
        public RequestRefundScreen()
        {
            InitializeComponent();
        }

        public string refundRequestScreenUsername { get; set; }

        string email;

        private void requestRefundButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in purchasesDataGridView.SelectedRows)
            {
                //To hold information about the purchase table and input it into the Repair table in the database
                string username = row.Cells[0].Value.ToString();
                string orderNumber = row.Cells[1].Value.ToString();
                string computer = row.Cells[2].Value.ToString();
                string console = row.Cells[3].Value.ToString();
                string television = row.Cells[4].Value.ToString();
                string tablet = row.Cells[5].Value.ToString();
                string price = row.Cells[6].Value.ToString();
                string stages = row.Cells[7].Value.ToString();

                MessageBox.Show("Order Number : " + orderNumber + " has been queued up for Refund!");

                //Set up Command type so the program can input into the table in the database
                SqlCommand addToRepairCommand = new SqlCommand();
                addToRepairCommand.CommandType = CommandType.Text;
                addToRepairCommand.CommandText = "INSERT into Refunds (RefundNumber, RefundStatus, Username, Computer, Console, Tablet, Television) VALUES ('" + orderNumber + "' , 'One', '" 
                    + refundRequestScreenUsername + "' , '" + computer + "' , '" + console + "' , '" + tablet + "' , '" + television + "')" + 
                    "UPDATE Purchases SET Stages= 'Refund' WHERE Stages= 'Six' AND OrderNumber= '" + orderNumber + "'";;

                //Establish a connection to the database and perform the addToRepairCommand
                addToRepairCommand.Connection = DatabaseOperations.sqlConnectionLink;
                DatabaseOperations.sqlConnectionLink.Open();
                addToRepairCommand.ExecuteNonQuery();
                DatabaseOperations.sqlConnectionLink.Close();

                //Update & Refresh datagridview for purchase table
                var select = "SELECT * FROM Purchases WHERE Username= '" + refundRequestScreenUsername + "' AND Stages= 'Six'";
                var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                purchasesDataGridView.DataSource = ds.Tables[0];
            }

            //Get the customers email
            string selectEmailSQL = "SELECT Email FROM CustomerInformation Where Username= '" + refundRequestScreenUsername + "'";
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

            //Send user an email to let them know there Repair Status has been updated
            var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toUserAddress = new MailAddress(email, refundRequestScreenUsername);
            const string fromPassword = "GSEPassword";
            const string subject = "Update on your Refund";
            string body = "Hello " + refundRequestScreenUsername + "\n\n" +
                "In order to process or refund your item, we are going to need you to ship your item back to the facility. If you could please send your item back to this address \n\n" +
                "Global Sanic Electronics" + "\n" +
                "8785 Windfall St \n" +
                "Whitehall, PA 18052" + "\n\n" +
                "We appreciate your assistance with this and we will refudn your money as soon as we get the item back.";

            //Establis a connection with the smtpclient and put the host and port number down
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
            using (var message = new MailMessage(fromAddress, toUserAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

            //Send user an email to let them know there Repair Status has been updated
            var fromUSAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            const string fromUSPassword = "GSEPassword";
            const string updateSubject = "User Requested Refund";
            string updateBody = "User : " + refundRequestScreenUsername + " has requested a refund";

            //Establis a connection with the smtpclient and put the host and port number down
            var _smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromUSPassword)
            };

            //Area to actually send the message out to the user
            using (var message = new MailMessage(fromUSAddress, toAddress)
            {
                Subject = updateSubject,
                Body = updateBody
            })
            {
                smtp.Send(message);
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.mainApplicationUsername = refundRequestScreenUsername;
            mainApplicationForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void purchasesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void RequestRefundScreen_Load(object sender, EventArgs e)
        {
            var select = "SELECT * FROM Purchases WHERE Username= '" + refundRequestScreenUsername + "' AND Stages= 'Six'";
            var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            purchasesDataGridView.DataSource = ds.Tables[0];
        }

        private void purchasesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void purchasesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }
    }
}
