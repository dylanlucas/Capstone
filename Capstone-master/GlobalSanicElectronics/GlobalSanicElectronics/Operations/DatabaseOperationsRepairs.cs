using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    class DatabaseOperationsRepairs
    {
        public static bool RequestRepairs(string repairScreenFormUsername)
        {
            //Declare variables
            bool verifyRepairTable;

            using (SqlCommand requestRepairCommand = new SqlCommand())
            {
                requestRepairCommand.CommandText = "SELECT * FROM Purchases WHERE Username LIKE @Username AND Stages LIKE @Stages";
                requestRepairCommand.Parameters.AddWithValue("@Username", repairScreenFormUsername);
                requestRepairCommand.Parameters.AddWithValue("@Stages", "Six");
                requestRepairCommand.Connection = DatabaseOperations.sqlConnectionLink;

                requestRepairCommand.Connection.Open();
                verifyRepairTable = requestRepairCommand.ExecuteReader().HasRows;
                requestRepairCommand.Connection.Close();
            }

            return verifyRepairTable;
        }

        public static void UserRequestRepairs(DataGridView purchaseDataGridView, string requestRepaireFormUsername)
        {
            using (SqlCommand userRequestRepairsCommand = new SqlCommand())
            {
                foreach (DataGridViewRow row in purchaseDataGridView.SelectedRows)
                {
                    //To hold information about the purchase table and input it into the Repair table in the database
                    string username = row.Cells[0].Value.ToString();
                    string orderNumber = row.Cells[1].Value.ToString();
                    string price = row.Cells[2].Value.ToString();
                    string stages = row.Cells[3].Value.ToString();

                    MessageBox.Show("Order Number : " + orderNumber + " has been queued up for Repair!");

                    userRequestRepairsCommand.CommandText = "INSERT into Repairs (RepairStatus, Username, OrderNumber) VALUES " +
                        "(@RepairStatus, @Username, @OrderNumber)" +
                        "UPDATE Purchases SET Stages= 'Repair' WHERE Stages= 'Six' AND OrderNumber LIKE @OrderNumber";
                    userRequestRepairsCommand.Parameters.AddWithValue("@RepairStatus", stages);
                    userRequestRepairsCommand.Parameters.AddWithValue("@Username", username);
                    userRequestRepairsCommand.Parameters.AddWithValue("@OrderNumber", orderNumber);
                    userRequestRepairsCommand.Connection = DatabaseOperations.sqlConnectionLink;

                    userRequestRepairsCommand.Connection.Open();
                    userRequestRepairsCommand.ExecuteNonQuery();
                    userRequestRepairsCommand.Connection.Close();
                }
            }
        }

        public static void RequestRepairScreen(string repairStatusScreenUsername, DataGridView purchasesDataGridView)
        {
            using (SqlCommand requestRepairScreenCommand = new SqlCommand())
            {
                requestRepairScreenCommand.CommandText = "SELECT * From Repairs WHERE Username LIKE @Username";
                requestRepairScreenCommand.Parameters.AddWithValue("@Username", repairStatusScreenUsername);
                requestRepairScreenCommand.Connection = DatabaseOperations.sqlConnectionLink;

                requestRepairScreenCommand.Connection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(requestRepairScreenCommand);
                da.Fill(ds);
                purchasesDataGridView.ReadOnly = true;
                purchasesDataGridView.DataSource = ds.Tables[0];
                requestRepairScreenCommand.Connection.Close();
            }
        }

        public static void FillRepair(string requestRepaireFormUsername, DataGridView purchaseDataGridView)
        {
            using (SqlCommand fillRepairCommand = new SqlCommand())
            {
                fillRepairCommand.CommandText = "SELECT * FROM Purchases WHERE Username LIKE @Username AND Stages LIKE @Stages";
                fillRepairCommand.Parameters.AddWithValue("@Username", requestRepaireFormUsername);
                fillRepairCommand.Parameters.AddWithValue("@Stages", "Six");
                fillRepairCommand.Connection = DatabaseOperations.sqlConnectionLink;

                fillRepairCommand.Connection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(fillRepairCommand);
                da.Fill(ds);
                purchaseDataGridView.DataSource = ds.Tables[0];
                fillRepairCommand.Connection.Close();
            }
        }

        public static void UpdateRepairStatus(ComboBox repairStatusComboBox, TextBox usernameTextBox, string email, DataGridView repairDirectory)
        {
            foreach (DataGridViewRow row in repairDirectory.SelectedRows)
            {
                string repairID = row.Cells[3].Value.ToString();

                //Variable to hold what is in the combo box
                string repairStatus = repairStatusComboBox.Text;

                SqlCommand updateRepairCommand = new SqlCommand();
                updateRepairCommand.CommandType = CommandType.Text;
                updateRepairCommand.CommandText = "UPDATE Repairs SET RepairStatus= '" + repairStatusComboBox.SelectedItem + "' WHERE RepairID= '" + repairID + "'";
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
            }
        }

        public static void UpdateRepairView(TextBox usernameTextBox, DataGridView repairsDataGridView)
        {
            //Update Repair status screen datagridview
            var select = "SELECT * FROM Repairs WHERE Username= '" + usernameTextBox.Text + "'";
            var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            repairsDataGridView.DataSource = ds.Tables[0];
        }

        public static void LoadRepairs(DataGridView repairsDataGridView, TextBox usernameTextBox)
        {
            //Update Repair status screen datagridview
            var select = "SELECT * FROM Repairs WHERE Username= '" + usernameTextBox.Text + "'";
            var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            repairsDataGridView.DataSource = ds.Tables[0];
        }
    }
}
