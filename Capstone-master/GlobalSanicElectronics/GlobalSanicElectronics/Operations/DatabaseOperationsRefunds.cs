﻿using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    class DatabaseOperationsRefunds
    {
        //Method to store information that the user wants to request a refund on the order
        public static void UserRequestRefunds(DataGridView purchaseDataGridView, string refundRequestsScreenUsername)
        {
            using (SqlCommand userRequestsRefundCommand = new SqlCommand())
            {
                foreach (DataGridViewRow row in purchaseDataGridView.SelectedRows)
                {
                    //To hold information about the purchase table and input it into the Refund table in the database
                    string username = row.Cells[0].Value.ToString();
                    string orderNumber = row.Cells[1].Value.ToString();
                    string price = row.Cells[2].Value.ToString();
                    string stages = row.Cells[3].Value.ToString();

                    MessageBox.Show("Order Number : " + orderNumber + " has been queued up for Refund!");

                    userRequestsRefundCommand.CommandText = "INSERT into Refunds (OrderNumber, RefundStatus, Username) VALUES " +
                        "(@OrderNumber, @RefundStatus, @Username)" +
                        "UPDATE Purchases SET Stages= 'Repair' WHERE Stages= 'Six' AND OrderNumber LIKE @OrderNumber";
                    userRequestsRefundCommand.Parameters.AddWithValue("@OrderNumber", orderNumber);
                    userRequestsRefundCommand.Parameters.AddWithValue("@RefundStatus", stages);
                    userRequestsRefundCommand.Parameters.AddWithValue("@Username", username);
                    userRequestsRefundCommand.Connection = DatabaseOperations.sqlConnectionLink;

                    userRequestsRefundCommand.Connection.Open();
                    userRequestsRefundCommand.ExecuteNonQuery();
                    userRequestsRefundCommand.Connection.Close();
                }
            }
        }

        //Method to get all information related to the user's refund
        public static void RequestRefundScreen(string refundRequestsScreenUsername, DataGridView purchaseDataGridView)
        {
            using (SqlCommand requestRepairScreenCommand = new SqlCommand())
            {
                requestRepairScreenCommand.CommandText = "SELECT * From Refunds WHERE Username LIKE @Username";
                requestRepairScreenCommand.Parameters.AddWithValue("@Username", refundRequestsScreenUsername);
                requestRepairScreenCommand.Connection = DatabaseOperations.sqlConnectionLink;

                requestRepairScreenCommand.Connection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(requestRepairScreenCommand);
                da.Fill(ds);
                purchaseDataGridView.ReadOnly = true;
                purchaseDataGridView.DataSource = ds.Tables[0];
                requestRepairScreenCommand.Connection.Close();
            }
        }

        //Method to update all refund information that the employee has set
        public static void UpdateRefundStatus(ComboBox refundStatusComboBox, TextBox usernameTextBox, string email, DataGridView refundDirectory)
        {
            foreach (DataGridViewRow row in refundDirectory.SelectedRows)
            {
                string refundID = row.Cells[3].Value.ToString();

                //Variable to hold what is in the combobox
                string refundStatus = refundStatusComboBox.Text;

                SqlCommand updateRefundCommand = new SqlCommand();
                updateRefundCommand.CommandType = CommandType.Text;
                updateRefundCommand.CommandText = "UPDATE Refunds SET RefundStatus= '" + refundStatusComboBox.SelectedItem + "' WHERE RefundID= '" + refundID + "'";
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
            }
        }

        //Method to update the refund view for the employee
        public static void UpdateRefundView(TextBox usernameTextBox, DataGridView refundsDataGridView)
        {
            var select = "SELECT * FROM Refunds WHERE Username= '" + usernameTextBox.Text + "'";
            var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            refundsDataGridView.DataSource = ds.Tables[0];
        }
    }
}
