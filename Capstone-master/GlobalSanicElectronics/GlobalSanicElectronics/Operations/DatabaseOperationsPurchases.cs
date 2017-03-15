using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    class DatabaseOperationsPurchases
    {
        public static bool TrackOrder(Purchases userPurchases, string username)
        {
            using (System.Data.SqlClient.SqlCommand validateOrder = new System.Data.SqlClient.SqlCommand())
            {
                validateOrder.CommandText = "SELECT * FROM Purchases WHERE Username Like @Username";
                validateOrder.Parameters.AddWithValue("@Username", username);
                validateOrder.Connection = DatabaseOperations.sqlConnectionLink;

                validateOrder.Connection.Open();
                bool verifyPurchases = validateOrder.ExecuteReader().HasRows;
                validateOrder.Connection.Close();

                return verifyPurchases;
            }
        }

        public static void ShippingInformation(string userName, TextBox addressTextBox, TextBox cityTextBox, TextBox stateTextBox, TextBox zipTextBox)
        {
            using (System.Data.SqlClient.SqlCommand selectShipingInformationCommand = new System.Data.SqlClient.SqlCommand())
            {
                selectShipingInformationCommand.CommandText = "SELECT Address, City, State, Zip FROM CustomerInformation WHERE Username Like @Username";
                selectShipingInformationCommand.Parameters.AddWithValue("@Username", userName);
                selectShipingInformationCommand.Connection = DatabaseOperations.sqlConnectionLink;

                try
                {
                    selectShipingInformationCommand.Connection.Open();

                    using (SqlDataReader reader = selectShipingInformationCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            addressTextBox.Text = (reader["Address"].ToString());
                            cityTextBox.Text = (reader["City"].ToString());
                            stateTextBox.Text = (reader["State"].ToString());
                            zipTextBox.Text = (reader["Zip"].ToString());
                        }
                    }
                }
                finally
                {
                    selectShipingInformationCommand.Connection.Close();
                }
            }
        }

        public static void HashCreditCard(TextBox cardNumberTextBox, TextBox nameTextBox, string userName, GroupBox paymentGroupBox)
        {
            string salt = "WquZ012C";

            var bytes = new UTF8Encoding().GetBytes(salt + cardNumberTextBox.Text);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }

            string creditcardHash = Convert.ToBase64String(hashBytes);

            using (System.Data.SqlClient.SqlCommand updateCCTable = new System.Data.SqlClient.SqlCommand())
            {
                updateCCTable.CommandText = "INSERT into CCInformation (CCNumber, CCName, Username) VALUES (@CCNumber, @CCName, @Username)";
                updateCCTable.Parameters.AddWithValue("@CCNumber", creditcardHash);
                updateCCTable.Parameters.AddWithValue("@CCName", nameTextBox.Text);
                updateCCTable.Parameters.AddWithValue("@Username", userName);
                updateCCTable.Connection = DatabaseOperations.sqlConnectionLink;

                updateCCTable.Connection.Open();
                updateCCTable.ExecuteNonQuery();
                updateCCTable.Connection.Close();

                paymentGroupBox.Enabled = false;
            }
        }

        public static void UpdatePurchases(string username, double number, string computer, string console, string television, string tablet, double price)
        {
            using (System.Data.SqlClient.SqlCommand updatePurchaseCommand = new System.Data.SqlClient.SqlCommand())
            {
                updatePurchaseCommand.CommandText = "INSERT Into Purchases (Username, OrderNumber, Price, Stages) VALUES" +
                    "(@Username, @OrderNumber, @Price, @Stages)";
                updatePurchaseCommand.Parameters.AddWithValue("@Username", username);
                updatePurchaseCommand.Parameters.AddWithValue("@OrderNumber", number);
                updatePurchaseCommand.Parameters.AddWithValue("@Price", price);
                updatePurchaseCommand.Parameters.AddWithValue("@Stages", "One");
                updatePurchaseCommand.Connection = DatabaseOperations.sqlConnectionLink;

                updatePurchaseCommand.Connection.Open();
                updatePurchaseCommand.ExecuteNonQuery();
                updatePurchaseCommand.Connection.Close();
            }
        }

        public static void LoadPurchases(DataGridView purchasesDataGridView)
        {
            var selectOrder = "SELECT * FROM Purchases";
            var orderDataAdapter = new SqlDataAdapter(selectOrder, DatabaseOperations.sqlConnectionLink);

            var orderCommandBuilder = new SqlCommandBuilder(orderDataAdapter);
            var orderDataSet = new DataSet();
            orderDataAdapter.Fill(orderDataSet);
            purchasesDataGridView.DataSource = orderDataSet.Tables[0];
        }

        public static void TrackUserOrder(string username, DataGridView purchaseDataGridView)
        {
            using (SqlCommand trackOrderCommand = new SqlCommand())
            {
                trackOrderCommand.CommandText = "SELECT * FROM Purchases WHERE Username LIKE @Username";
                trackOrderCommand.Parameters.AddWithValue("@Username", username);
                trackOrderCommand.Connection = DatabaseOperations.sqlConnectionLink;

                trackOrderCommand.Connection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(trackOrderCommand);
                da.Fill(ds);
                purchaseDataGridView.ReadOnly = true;
                purchaseDataGridView.DataSource = ds.Tables[0];
                trackOrderCommand.Connection.Close();
            }
        }
    }
}
