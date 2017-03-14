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

        public static void CreateUser(CustomerInformation customer)
        {
            using (System.Data.SqlClient.SqlCommand createUserCommand = new System.Data.SqlClient.SqlCommand())
            {
                createUserCommand.CommandText = ("INSERT into CustomerInformation (Username, Password, Email, DOB, Address, City, State, Zip) VALUES " +
                    "(@Username, @Password, @Email, @DOB, @Address, @City, @State, @Zip)");
                createUserCommand.Parameters.AddWithValue("@Username", customer.Username);
                createUserCommand.Parameters.AddWithValue("@Password", customer.Password);
                createUserCommand.Parameters.AddWithValue("@Email", customer.Email);
                createUserCommand.Parameters.AddWithValue("DOB", customer.DOB);
                createUserCommand.Parameters.AddWithValue("@Address", customer.Address);
                createUserCommand.Parameters.AddWithValue("@City", customer.City);
                createUserCommand.Parameters.AddWithValue("@State", customer.State);
                createUserCommand.Parameters.AddWithValue("@Zip", customer.Zip);
                createUserCommand.Connection = DatabaseOperations.sqlConnectionLink;

                DatabaseOperations.sqlConnectionLink.Open();
                createUserCommand.ExecuteNonQuery();
                DatabaseOperations.sqlConnectionLink.Close();
            }
        }

        public static bool SelectUser(CustomerInformation customer, TextBox password)
        {
            using (System.Data.SqlClient.SqlCommand searchUserCommand = new System.Data.SqlClient.SqlCommand())
            {
                searchUserCommand.CommandText = ("SELECT * From CustomerInformation WHERE Username Like @Username AND Password = @Password;");
                searchUserCommand.Parameters.AddWithValue("@Username", customer.Username);
                searchUserCommand.Parameters.AddWithValue("@Password", PasswordOperations.AccountPasswordHashing(password.Text));
                searchUserCommand.Connection = DatabaseOperations.sqlConnectionLink;
                DatabaseOperations.sqlConnectionLink.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(searchUserCommand);
                da.Fill(ds);
                DatabaseOperations.sqlConnectionLink.Close();

                bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                return loginSuccessful;
            }
        }

        public static void TelevisionCart(TelevisionDirectory TV, DataGridView televisionDirectory, string username)
        {
            foreach (DataGridViewRow row in televisionDirectory.SelectedRows)
            {
                //To hold information about the Television and input it into the Cart table in the database
                TV.TVID = row.Cells[0].Value.ToString();
                TV.Brand = row.Cells[1].Value.ToString();
                TV.Size = row.Cells[2].Value.ToString();
                TV.LED = bool.Parse(row.Cells[3].Value.ToString());
                TV.Smart = bool.Parse(row.Cells[4].Value.ToString());
                TV.Resolution = row.Cells[5].Value.ToString();
                TV.Color = row.Cells[6].Value.ToString();
                TV.Price = row.Cells[7].Value.ToString();

                MessageBox.Show(TV.Brand + " television has been added to your cart with the price of $" + TV.Price);

                using (System.Data.SqlClient.SqlCommand addTelevisionToCartCommand = new System.Data.SqlClient.SqlCommand())
                {
                    addTelevisionToCartCommand.CommandText = ("INSERT into Cart (Username, Computer, Console, Tablet, Television, Brand, Size, LED, Smart, Resolution, Color, Price) VALUES " +
                        "(@Username, @Computer, @Console, @Tablet, @Television, @Brand, @Size, @LED, @Smart, @Resolution, @Color, @Price)");
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Username", username);
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Computer", "No");
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Console", "No");
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Tablet", "No");
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Television", "Yes");
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Brand", TV.Brand);
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Size", TV.Size);
                    addTelevisionToCartCommand.Parameters.AddWithValue("@LED", TV.LED);
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Smart", TV.Smart);
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Resolution", TV.Resolution);
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Color", TV.Color);
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Price", TV.Price);
                    addTelevisionToCartCommand.Connection = DatabaseOperations.sqlConnectionLink;

                    DatabaseOperations.sqlConnectionLink.Open();
                    addTelevisionToCartCommand.ExecuteNonQuery();
                    DatabaseOperations.sqlConnectionLink.Close();
                }
            }
        }

        public static void TabletCart(TabletDirectory Tablet, DataGridView tabletDirectory, string username)
        {
            foreach (DataGridViewRow row in tabletDirectory.SelectedRows)
            {
                //To hold information about the Tablet and input it into the Cart table in the database
                Tablet.TabletID = int.Parse(row.Cells[0].Value.ToString());
                Tablet.Brand = row.Cells[1].Value.ToString();
                Tablet.Size = row.Cells[2].Value.ToString();
                Tablet.Storage = row.Cells[3].Value.ToString();
                Tablet.Processor = row.Cells[4].Value.ToString();
                Tablet.Wifi = row.Cells[5].Value.ToString();
                Tablet.Color = row.Cells[6].Value.ToString();
                Tablet.Price = row.Cells[7].Value.ToString();

                MessageBox.Show(Tablet.Brand + " tablet has been added to your cart with the price of $" + Tablet.Price);

                using (System.Data.SqlClient.SqlCommand addTabletToCartCommand = new System.Data.SqlClient.SqlCommand())
                {
                    addTabletToCartCommand.CommandText = ("INSERT into Cart (Username, Computer, Console, Tablet, Television, Brand, Size, Storage, Processor, Wifi, Color, Price) VALUES " +
                        "(@Username, @Computer, @Console, @Tablet, @Television, @Brand, @Size, @Storage, @Processor, @Wifi, @Color, @Price)");
                    addTabletToCartCommand.Parameters.AddWithValue("@Username", username);
                    addTabletToCartCommand.Parameters.AddWithValue("@Computer", "No");
                    addTabletToCartCommand.Parameters.AddWithValue("@Console", "No");
                    addTabletToCartCommand.Parameters.AddWithValue("@Tablet", "Yes");
                    addTabletToCartCommand.Parameters.AddWithValue("@Television", "No");
                    addTabletToCartCommand.Parameters.AddWithValue("@Brand", Tablet.Brand);
                    addTabletToCartCommand.Parameters.AddWithValue("@Size", Tablet.Size);
                    addTabletToCartCommand.Parameters.AddWithValue("@Storage", Tablet.Storage);
                    addTabletToCartCommand.Parameters.AddWithValue("@Processor", Tablet.Processor);
                    addTabletToCartCommand.Parameters.AddWithValue("@Wifi", Tablet.Wifi);
                    addTabletToCartCommand.Parameters.AddWithValue("@Color", Tablet.Color);
                    addTabletToCartCommand.Parameters.AddWithValue("@Price", Tablet.Price);
                    addTabletToCartCommand.Connection = DatabaseOperations.sqlConnectionLink;

                    DatabaseOperations.sqlConnectionLink.Open();
                    addTabletToCartCommand.ExecuteNonQuery();
                    DatabaseOperations.sqlConnectionLink.Close();
                }
            }
        }

        public static void ConsoleCart(ConsoleDirectory Console, DataGridView consoleDirectory, string username)
        {
            foreach (DataGridViewRow row in consoleDirectory.SelectedRows)
            {
                //To hold information about the Console and input it into the Cart table in the database
                Console.ConsoleID = int.Parse(row.Cells[0].Value.ToString());
                Console.Brand = row.Cells[1].Value.ToString();
                Console.Storage = row.Cells[2].Value.ToString();
                Console.Price = row.Cells[3].Value.ToString();


                MessageBox.Show(Console.Brand + " console has been added to your cart with the price of $" + Console.Price);

                using (System.Data.SqlClient.SqlCommand addConsoleToCartCommand = new System.Data.SqlClient.SqlCommand())
                {
                    addConsoleToCartCommand.CommandText = ("INSERT into Cart (Username, Computer, Console, Tablet, Television, Brand, Storage, Price) VALUES " +
                        "(@Username, @Computer, @Console, @Tablet, @Television, @Brand, @Storage, @Price)");
                    addConsoleToCartCommand.Parameters.AddWithValue("@Username", username);
                    addConsoleToCartCommand.Parameters.AddWithValue("@Computer", "No");
                    addConsoleToCartCommand.Parameters.AddWithValue("@Console", "Yes");
                    addConsoleToCartCommand.Parameters.AddWithValue("@Tablet", "No");
                    addConsoleToCartCommand.Parameters.AddWithValue("@Television", "No");
                    addConsoleToCartCommand.Parameters.AddWithValue("@Brand", Console.Brand);
                    addConsoleToCartCommand.Parameters.AddWithValue("@Storage", Console.Storage);
                    addConsoleToCartCommand.Parameters.AddWithValue("@Price", Console.Price);
                    addConsoleToCartCommand.Connection = DatabaseOperations.sqlConnectionLink;

                    DatabaseOperations.sqlConnectionLink.Open();
                    addConsoleToCartCommand.ExecuteNonQuery();
                    DatabaseOperations.sqlConnectionLink.Close();
                }
            }
        }

        public static void ComputerCart(ComputerDirectory Computer, DataGridView computerDirectory, string username)
        {
            foreach (DataGridViewRow row in computerDirectory.SelectedRows)
            {
                //To hold information about the Computer and input it into the Cart table in the database
                Computer.ComputerID = int.Parse(row.Cells[0].Value.ToString());
                Computer.Brand = row.Cells[1].Value.ToString();
                Computer.Size = row.Cells[2].Value.ToString();
                Computer.Processor = row.Cells[3].Value.ToString();
                Computer.Storage = row.Cells[4].Value.ToString();
                Computer.RAM = row.Cells[5].Value.ToString();
                Computer.Color = row.Cells[6].Value.ToString();
                Computer.Price = row.Cells[7].Value.ToString();

                MessageBox.Show(Computer.Brand + " computer has been added to your cart with the price of $" + Computer.Price);

                using (System.Data.SqlClient.SqlCommand addToComputerCommand = new System.Data.SqlClient.SqlCommand())
                {
                    addToComputerCommand.CommandText = ("INSERT into Cart (Username, Computer, Console, Tablet, Television, Brand, Size, Processor, Storage, RAM, Color, Price) VALUES " +
                        "(@Username, @Computer, @Console, @Tablet, @Television, @Brand, @Size, @Processor, @Storage, @RAM, @Color, @Price)");
                    addToComputerCommand.Parameters.AddWithValue("@Username", username);
                    addToComputerCommand.Parameters.AddWithValue("@Computer", "Yes");
                    addToComputerCommand.Parameters.AddWithValue("Console", "No");
                    addToComputerCommand.Parameters.AddWithValue("@Tablet", "No");
                    addToComputerCommand.Parameters.AddWithValue("@Television", "No");
                    addToComputerCommand.Parameters.AddWithValue("@Brand", Computer.Brand);
                    addToComputerCommand.Parameters.AddWithValue("@Size", Computer.Size);
                    addToComputerCommand.Parameters.AddWithValue("@Processor", Computer.Processor);
                    addToComputerCommand.Parameters.AddWithValue("@Storage", Computer.Storage);
                    addToComputerCommand.Parameters.AddWithValue("@RAM", Computer.RAM);
                    addToComputerCommand.Parameters.AddWithValue("@Color", Computer.Color);
                    addToComputerCommand.Parameters.AddWithValue("@Price", Computer.Price);
                    addToComputerCommand.Connection = DatabaseOperations.sqlConnectionLink;

                    DatabaseOperations.sqlConnectionLink.Open();
                    addToComputerCommand.ExecuteNonQuery();
                    DatabaseOperations.sqlConnectionLink.Close();
                }
            }
        }

        public static void CartDisplay(Cart userCart, string username, Label cartDisplayLabel)
        {
            using (System.Data.SqlClient.SqlCommand cartDisplayCommand = new System.Data.SqlClient.SqlCommand())
            {
                cartDisplayCommand.CommandText = "SELECT COUNT(*) FROM Cart WHERE Username Like @Username";
                cartDisplayCommand.Parameters.AddWithValue("@Username", username);
                cartDisplayCommand.Connection = DatabaseOperations.sqlConnectionLink;

                cartDisplayCommand.Connection.Open();
                cartDisplayLabel.Text = cartDisplayCommand.ExecuteScalar().ToString();
                cartDisplayCommand.Connection.Close();
            }
        }

        public static void CartPrice(Cart userCart, string username, Label cartPriceDisplayLabel)
        {
            using (System.Data.SqlClient.SqlCommand priceCommand = new System.Data.SqlClient.SqlCommand())
            {
                priceCommand.CommandText = "SELECT SUM(Price) FROM Cart WHERE Username Like @Username";
                priceCommand.Parameters.AddWithValue("@Username", username);
                priceCommand.Connection = DatabaseOperations.sqlConnectionLink;

                priceCommand.Connection.Open();
                cartPriceDisplayLabel.Text = "$" + priceCommand.ExecuteScalar().ToString();
                priceCommand.Connection.Close();
            }
        }

        public static bool CartValidation(Cart userCart, string username)
        {
            using (System.Data.SqlClient.SqlCommand validateCart = new System.Data.SqlClient.SqlCommand())
            {
                validateCart.CommandText = "SELECT * FROM Cart WHERE Username Like @Username";
                validateCart.Parameters.AddWithValue("@Username", username);
                validateCart.Connection = DatabaseOperations.sqlConnectionLink;

                validateCart.Connection.Open();
                bool verifyCart = validateCart.ExecuteReader().HasRows;
                validateCart.Connection.Close();

                return verifyCart;

            }
        }
        
        public static void ShowCart(Cart userCart, string username, DataGridView cartDirectory)
        {
            using (System.Data.SqlClient.SqlCommand showCartCommand = new System.Data.SqlClient.SqlCommand())
            {
                showCartCommand.CommandText = "SELECT * FROM Cart WHERE Username Like @Username";
                showCartCommand.Parameters.AddWithValue("@Username", username);
                showCartCommand.Connection = DatabaseOperations.sqlConnectionLink;

                showCartCommand.Connection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(showCartCommand);
                da.Fill(ds);
                cartDirectory.ReadOnly = true;
                cartDirectory.DataSource = ds.Tables[0];
                showCartCommand.Connection.Close();
            }
        }

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

        public static void RemoveItem(Cart userCart, DataGridView cartDirectory, GSEDatabaseDataSetTableAdapters.CartTableAdapter cartDataAdapter, GSEDatabaseDataSet gSEDatabaseDataSet)
        {            
            foreach (DataGridViewRow row in cartDirectory.SelectedRows)
            {
                userCart.CartID = int.Parse(row.Cells[16].Value.ToString());

                cartDirectory.Rows.RemoveAt(row.Index);

                using (System.Data.SqlClient.SqlCommand removeOrder = new System.Data.SqlClient.SqlCommand())
                {
                    //Declare Variables
                    Int32 removeAndUpdateCart;

                    removeOrder.CommandText = "DELETE FROM Cart WHERE CartID Like @CartID";
                    removeOrder.Parameters.AddWithValue("@CartID", userCart.CartID);
                    removeOrder.Connection = DatabaseOperations.sqlConnectionLink;

                    removeOrder.Connection.Open();
                    removeAndUpdateCart = Convert.ToInt32(removeOrder.ExecuteScalar());
                    removeOrder.Connection.Close();

                    MessageBox.Show("Item has been removed from your cart!");

                    cartDirectory.Update();
                    cartDataAdapter.Update(gSEDatabaseDataSet.Cart);
                    cartDirectory.Refresh();
                }
            }
        }

        public static double DisplayCart(Cart userCart, DataGridView cartDirectory, string username, TabControl consoleTabControl, RadioButton consoleBundleRadioButton, 
            RadioButton consoleWarrantyRadioButton, GroupBox computerGroupBox, RadioButton computerWarrantyRadioButton, GroupBox tabletGroupBox, RadioButton tabletWarrantyRadioButton,
            GroupBox televisionGroupBox, RadioButton televisionWarrantyRadioButton, bool consoleYesNo, bool computerYesNo, bool tabletYesNo, bool televisionYesNo, double userPrice)
        {
            using (System.Data.SqlClient.SqlCommand displayCartCommand = new System.Data.SqlClient.SqlCommand())
            {
                displayCartCommand.CommandText = "SELECT Console, Computer, Tablet, Television, Brand, Price FROM Cart WHERE Username Like @Username";
                displayCartCommand.Parameters.AddWithValue("@Username", username);
                displayCartCommand.Connection = DatabaseOperations.sqlConnectionLink;

                displayCartCommand.Connection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(displayCartCommand);
                da.Fill(ds);
                cartDirectory.ReadOnly = true;
                cartDirectory.DataSource = ds.Tables[0];
                displayCartCommand.Connection.Close();

                cartDirectory.SelectAll();

                if (cartDirectory.RowCount > 0)
                {
                    var lastRow = cartDirectory.Rows[cartDirectory.RowCount - 1];
                    lastRow.Selected = false;

                    foreach (DataGridViewRow row in cartDirectory.SelectedRows)
                    {
                        userCart.Computer = row.Cells[0].Value.ToString();
                        userCart.Console = row.Cells[1].Value.ToString();
                        userCart.Tablet = row.Cells[2].Value.ToString();
                        userCart.Television = row.Cells[3].Value.ToString();
                        string price = row.Cells[5].Value.ToString();

                        userPrice += double.Parse(price);

                        if (userCart.Console == "Yes")
                        {
                            consoleYesNo = true;
                            consoleTabControl.Enabled = true;
                            consoleBundleRadioButton.Checked = true;
                            consoleWarrantyRadioButton.Checked = true;
                        }

                        if (userCart.Computer == "Yes")
                        {
                            computerYesNo = true;
                            computerGroupBox.Enabled = true;
                            computerWarrantyRadioButton.Checked = true;
                        }

                        if (userCart.Tablet == "Yes")
                        {
                            tabletYesNo = true;
                            tabletGroupBox.Enabled = true;
                            tabletWarrantyRadioButton.Checked = true;
                        }

                        if (userCart.Television == "Yes")
                        {
                            televisionYesNo = true;
                            televisionGroupBox.Enabled = true;
                            televisionWarrantyRadioButton.Checked = true;
                        }
                    }
                }

                return userPrice;
            }
        }
    }
}
