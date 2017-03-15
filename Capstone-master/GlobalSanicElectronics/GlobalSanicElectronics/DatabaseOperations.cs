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
        #region UserQueries

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

        #endregion        

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
                    addTelevisionToCartCommand.CommandText = ("INSERT into Cart (Username, TelevisionID, Brand, Size, LED, Smart, Resolution, Color, Price) VALUES " +
                        "(@Username, @TelevisionID, @Brand, @Size, @LED, @Smart, @Resolution, @Color, @Price)");
                    addTelevisionToCartCommand.Parameters.AddWithValue("@Username", username);
                    addTelevisionToCartCommand.Parameters.AddWithValue("@TelevisionID", TV.TVID);
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
                    addTabletToCartCommand.CommandText = ("INSERT into Cart (Username, TabletID, Brand, Size, Storage, Processor, Wifi, Color, Price) VALUES " +
                        "(@Username, @TabletID, @Brand, @Size, @Storage, @Processor, @Wifi, @Color, @Price)");
                    addTabletToCartCommand.Parameters.AddWithValue("@Username", username);
                    addTabletToCartCommand.Parameters.AddWithValue("@TabletID", Tablet.TabletID);
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
                    addConsoleToCartCommand.CommandText = ("INSERT into Cart (Username, ConsoleID, Brand, Storage, Price) VALUES " +
                        "(@Username, @ConsoleID, @Brand, @Storage, @Price)");
                    addConsoleToCartCommand.Parameters.AddWithValue("@Username", username);
                    addConsoleToCartCommand.Parameters.AddWithValue("@ConsoleID", Console.ConsoleID);
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
                    addToComputerCommand.CommandText = ("INSERT into Cart (Username, ComputerID, Brand, Size, Processor, Storage, RAM, Color, Price) VALUES " +
                        "(@Username, @ComputerID, @Brand, @Size, @Processor, @Storage, @RAM, @Color, @Price)");
                    addToComputerCommand.Parameters.AddWithValue("@Username", username);
                    addToComputerCommand.Parameters.AddWithValue("@ComputerID", Computer.ComputerID);
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

        private static ComputerDirectory GetComputerByID(int id)
        {
            using (SqlCommand getCommand = new SqlCommand())
            {
                getCommand.CommandText = "SELECT * FROM ComputerDirectory WHERE ComputerID LIKE @ComputerID";
                getCommand.Parameters.AddWithValue("@ComputerID", id);
                getCommand.Connection = DatabaseOperations.sqlConnectionLink;

                ComputerDirectory requestedComputer = new ComputerDirectory();

                getCommand.Connection.Open();

                using (SqlDataReader reader = getCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        requestedComputer.Brand = reader["Brand"].ToString();
                        requestedComputer.Price = reader["Price"].ToString();
                    }

                }

                getCommand.Connection.Close();

                return requestedComputer;
            }
        }

        private static ConsoleDirectory GetConsoleByID(int id)
        {
            using (SqlCommand getCommand = new SqlCommand())
            {
                getCommand.CommandText = "SELECT * FROM ConsoleDirectory WHERE ConsoleID LIKE @ConsoleID";
                getCommand.Parameters.AddWithValue("@ConsoleID", id);
                getCommand.Connection = DatabaseOperations.sqlConnectionLink;

                ConsoleDirectory requestedConsole = new ConsoleDirectory();

                getCommand.Connection.Open();

                using (SqlDataReader reader = getCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        requestedConsole.Brand = reader["Brand"].ToString();
                        requestedConsole.Price = reader["Price"].ToString();
                    }

                }

                getCommand.Connection.Close();

                return requestedConsole;
            }
        }

        private static TabletDirectory GetTabletByID(int id)
        {
            using (SqlCommand getCommand = new SqlCommand())
            {
                getCommand.CommandText = "SELECT * FROM TabletDirectory WHERE TabletID LIKE @TabletID";
                getCommand.Parameters.AddWithValue("@TabletID", id);
                getCommand.Connection = DatabaseOperations.sqlConnectionLink;

                TabletDirectory requestedTablet = new TabletDirectory();

                getCommand.Connection.Open();

                using (SqlDataReader reader = getCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        requestedTablet.Brand = reader["Brand"].ToString();
                        requestedTablet.Price = reader["Price"].ToString();
                    }

                }

                getCommand.Connection.Close();

                return requestedTablet;
            }
        }

        private static TelevisionDirectory GetTelevisionByID(int id)
        {
            using (SqlCommand getCommand = new SqlCommand())
            {
                getCommand.CommandText = "SELECT * FROM TelevisionDirectory WHERE TelevisionID LIKE @TelevisionID";
                getCommand.Parameters.AddWithValue("@TelevisionID", id);
                getCommand.Connection = DatabaseOperations.sqlConnectionLink;

                TelevisionDirectory requestedTelevision = new TelevisionDirectory();

                getCommand.Connection.Open();

                using (SqlDataReader reader = getCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        requestedTelevision.Brand = reader["Brand"].ToString();
                        requestedTelevision.Price = reader["Price"].ToString();
                    }

                }

                getCommand.Connection.Close();

                return requestedTelevision;
            }
        }

        public static Cart GetCart(string username)
        {
            Cart userCart = new Cart();
            List<int> compIDs = new List<int>();
            List<int> consoleIDs = new List<int>();
            List<int> televisionIDs = new List<int>();
            List<int> tabletIDs = new List<int>();

            using (SqlCommand getCartCommand = new SqlCommand())
            {
                getCartCommand.CommandText = "SELECT * FROM Cart WHERE Username Like @Username";
                getCartCommand.Parameters.AddWithValue("@Username", username);
                getCartCommand.Connection = DatabaseOperations.sqlConnectionLink;

                try
                {
                    getCartCommand.Connection.Open();

                    using (SqlDataReader reader = getCartCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["ComputerID"].ToString();
                            if (string.IsNullOrEmpty(id) == false)
                            {
                                compIDs.Add(int.Parse(reader["ComputerID"].ToString()));
                            }

                            id = string.Empty;
                            id = reader["ConsoleID"].ToString();
                            if (string.IsNullOrEmpty(id) == false)
                            {
                                consoleIDs.Add(int.Parse(reader["ConsoleID"].ToString()));
                            }

                            id = string.Empty;
                            id = reader["TelevisionID"].ToString();
                            if (string.IsNullOrEmpty(id) == false)
                            {
                                televisionIDs.Add(int.Parse(reader["TelevisionID"].ToString()));
                            }

                            id = string.Empty;
                            id = reader["TabletID"].ToString();
                            if (string.IsNullOrEmpty(id) == false)
                            {
                                tabletIDs.Add(int.Parse(reader["TabletID"].ToString()));
                            }
                        }
                    }
                }
                finally
                {
                    getCartCommand.Connection.Close();
                }
            }

            foreach(int computerID in compIDs)
            {
                userCart.Computers.Add(GetComputerByID(computerID));
            }

            foreach(int consoleID in consoleIDs)
            {
                userCart.Consoles.Add(GetConsoleByID(consoleID));
            }

            foreach(int tabletID in tabletIDs)
            {
                userCart.Tablets.Add(GetTabletByID(tabletID));
            }

            foreach(int televisionID in televisionIDs)
            {
                userCart.Televisions.Add(GetTelevisionByID(televisionID));
            }

            return userCart;
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
                cartDirectory.Rows.RemoveAt(row.Index);

                using (System.Data.SqlClient.SqlCommand removeOrder = new System.Data.SqlClient.SqlCommand())
                {
                    removeOrder.CommandText = "DELETE FROM Cart WHERE Username Like @Username";
                    removeOrder.Parameters.AddWithValue("@Username", userCart.Username);
                    removeOrder.Connection = DatabaseOperations.sqlConnectionLink;

                    removeOrder.Connection.Open();
                    removeOrder.ExecuteNonQuery();
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
            GroupBox televisionGroupBox, RadioButton televisionWarrantyRadioButton, bool consoleYesNo, bool computerYesNo, bool tabletYesNo, bool televisionYesNo, double userPrice,
            OrderScreenPartTwo orderScreenPartTwoForm)
        {
            using (System.Data.SqlClient.SqlCommand displayCartCommand = new System.Data.SqlClient.SqlCommand())
            {
                displayCartCommand.CommandText = "SELECT ConsoleID, ComputerID, TabletID, TelevisionID, Brand, Price FROM Cart WHERE Username Like @Username";
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
                        string price = row.Cells[11].Value.ToString();
                        string ComputerID = row.Cells[12].Value.ToString();
                        string ConsoleID = row.Cells[13].Value.ToString();
                        string TabletID = row.Cells[14].Value.ToString();
                        string TelevisionID = row.Cells[15].Value.ToString();

                        userPrice += double.Parse(price);

                        if (userCart.ConsoleID != null)
                        {
                            consoleYesNo = true;
                            consoleTabControl.Enabled = true;
                            consoleBundleRadioButton.Checked = true;
                            consoleWarrantyRadioButton.Checked = true;
                        }

                        if (string.IsNullOrEmpty(ComputerID) == false)
                        {
                            computerYesNo = true;
                            computerGroupBox.Enabled = true;
                            computerWarrantyRadioButton.Checked = true;
                        }

                        if (userCart.TabletID != null)
                        {
                            tabletYesNo = true;
                            tabletGroupBox.Enabled = true;
                            tabletWarrantyRadioButton.Checked = true;
                        }

                        if (userCart.TelevisionID != null)
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

        public static void DeleteEntireCart(string username)
        {
            using (System.Data.SqlClient.SqlCommand deleteCartCommand = new System.Data.SqlClient.SqlCommand())
            {
                deleteCartCommand.CommandText = "DELETE FROM Cart WHERE Username Like @Username";
                deleteCartCommand.Parameters.AddWithValue("@Username", username);
                deleteCartCommand.Connection = DatabaseOperations.sqlConnectionLink;

                deleteCartCommand.Connection.Open();
                deleteCartCommand.ExecuteNonQuery();
                deleteCartCommand.Connection.Close();
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

                    MessageBox.Show("Order Number : " + orderNumber + "has been queued up for Repair!");

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

                    MessageBox.Show("Order Number : " + orderNumber + " has been queued up for Repair!");

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

        public static void UpdateRepairStatus(ComboBox repairStatusComboBox, TextBox usernameTextBox, string email)
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
        }

        public static void UpdateRefundStatus(ComboBox refundStatusComboBox, TextBox usernameTextBox, string email)
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

        public static void UpdateRefundView(TextBox usernameTextBox, DataGridView refundsDataGridView)
        {
            var select = "SELECT * FROM Refunds WHERE Username= '" + usernameTextBox.Text + "'";
            var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            refundsDataGridView.DataSource = ds.Tables[0];
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
