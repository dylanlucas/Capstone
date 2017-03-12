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
    public partial class EmployeeScreen : Form
    {
        public EmployeeScreen()
        {
            InitializeComponent();
        }

        //Declare variables
        string email;           //Hold the user's email

        private void updateRepairStatus_Click(object sender, EventArgs e)
        {
            //Variable to hold what is in the combo box
            string repairStatus = repairStatusComboBox.Text;

            SqlCommand updateRepairCommand = new SqlCommand();
            updateRepairCommand.CommandType = CommandType.Text;
            updateRepairCommand.CommandText = "UPDATE Repairs SET RepairStatus= '" + repairStatusComboBox.SelectedItem + "' WHERE Username= '" + usernameTextBox.Text + "'";
            updateRepairCommand.Connection = DatabaseOperations.sqlConnectionLink;
            DatabaseOperations.sqlConnectionLink.Open();
            updateRepairCommand.ExecuteNonQuery();
            DatabaseOperations.sqlConnectionLink.Close();

            MessageBox.Show("Repair Status has been updated");

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

            if (repairStatus == "Two")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Repair";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Your order has been received by Global Sanic Electronics" + "\n\n" +
                    "We will continue to update you on the status of your repair!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

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
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (repairStatus == "Three")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Repair";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, The problem is currently being investigated" + "\n" +
                    "We will continue to update you on the status of your repair!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

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
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (repairStatus == "Four")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Repair";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Problem has been found and is being repaired" + "\n" +
                    "We will continue to update you on the status of your repair!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

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
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }   
            else if (repairStatus == "Five")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Repair";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Order has been successfully repaired and is being shipped back" + "\n" +
                    "We will continue to update you on the status of your repair!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

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
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (repairStatus == "Six")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Repair";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Order has been shipped back to you" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

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
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }

            //Update Repair status screen datagridview
            var select = "SELECT * FROM Repairs WHERE Username= '" + usernameTextBox.Text + "'";
            var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            repairsDataGridView.DataSource = ds.Tables[0];
        }

        private void updateRefundButton_Click(object sender, EventArgs e)
        {
            //Variable to hold what is in the combobox
            string refundStatus = refundStatusComboBox.Text;

            SqlCommand updateRefundCommand = new SqlCommand();
            updateRefundCommand.CommandType = CommandType.Text;
            updateRefundCommand.CommandText = "UPDATE Refunds SET RefundStatus= '" + refundStatusComboBox.SelectedItem + "' WHERE Username= '" + usernameTextBox.Text + "'";
            updateRefundCommand.Connection = DatabaseOperations.sqlConnectionLink;
            DatabaseOperations.sqlConnectionLink.Open();
            updateRefundCommand.ExecuteNonQuery();
            DatabaseOperations.sqlConnectionLink.Close();

            MessageBox.Show("Refund Status has been updated");

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

            if (refundStatus == "Two")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Refund";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Your order has been received by Global Sanic Electronics" + "\n" +
                    "We will continue to update you on the status of your refund!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

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
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (refundStatus == "Three")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Refund";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Your refund is currently being processed by Global Sanic Electronics" + "\n" +
                    "We will continue to update you on the status of your refund!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

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
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (refundStatus == "Four")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Refund";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Your refund has been transacted from Global Sanic Electronics to your bank provider" + "\n" +
                    "We will continue to update you on the status of your refund!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

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
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (refundStatus == "Five")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Refund";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Your refund should be complete now" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

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
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }

            //Update Refund status screen datagridview
            var select = "SELECT * FROM Refunds WHERE Username= '" + usernameTextBox.Text + "'";
            var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            refundsDataGridView.DataSource = ds.Tables[0];
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //As user has opted to log out, take them back to Launch Screen giving them the option to resign in or close out of the application completely from there
            LaunchScreen launchScreenForm = new LaunchScreen();
            launchScreenForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application out when the user clicks Exit
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void EmployeeScreen_Load(object sender, EventArgs e)
        {
            var selectOrder = "SELECT * FROM Purchases";
            var orderDataAdapter = new SqlDataAdapter(selectOrder, DatabaseOperations.sqlConnectionLink);

            var orderCommandBuilder = new SqlCommandBuilder(orderDataAdapter);
            var orderDataSet = new DataSet();
            orderDataAdapter.Fill(orderDataSet);
            purchasesDataGridView.DataSource = orderDataSet.Tables[0];
        }

        private void purchasesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

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

        private void purchasesBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void loadCustomerInformationButton_Click(object sender, EventArgs e)
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
                    string computer = row.Cells[2].Value.ToString();
                    string console = row.Cells[3].Value.ToString();
                    string television = row.Cells[4].Value.ToString();
                    string tablet = row.Cells[5].Value.ToString();
                    string price = row.Cells[6].Value.ToString();
                    string stages = row.Cells[7].Value.ToString();

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
