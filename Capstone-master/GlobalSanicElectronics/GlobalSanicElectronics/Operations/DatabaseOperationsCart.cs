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
    class DatabaseOperationsCart
    {
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

            foreach (int computerID in compIDs)
            {
                userCart.Computers.Add(GetComputerByID(computerID));
            }

            foreach (int consoleID in consoleIDs)
            {
                userCart.Consoles.Add(GetConsoleByID(consoleID));
            }

            foreach (int tabletID in tabletIDs)
            {
                userCart.Tablets.Add(GetTabletByID(tabletID));
            }

            foreach (int televisionID in televisionIDs)
            {
                userCart.Televisions.Add(GetTelevisionByID(televisionID));
            }

            return userCart;
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
                        userCart.Price = row.Cells[11].Value.ToString();
                        userCart.ComputerID = row.Cells[12].Value.ToString();
                        userCart.ConsoleID = row.Cells[13].Value.ToString();
                        userCart.TabletID = row.Cells[14].Value.ToString();
                        userCart.TelevisionID = row.Cells[15].Value.ToString();

                        userPrice += double.Parse(userCart.Price);

                        if (string.IsNullOrEmpty(userCart.ConsoleID) == false)
                        {
                            consoleYesNo = true;
                            consoleTabControl.Enabled = true;
                            consoleBundleRadioButton.Checked = true;
                            consoleWarrantyRadioButton.Checked = true;
                        }

                        if (string.IsNullOrEmpty(userCart.ComputerID) == false)
                        {
                            computerYesNo = true;
                            computerGroupBox.Enabled = true;
                            computerWarrantyRadioButton.Checked = true;
                        }

                        if (string.IsNullOrEmpty(userCart.TabletID) == false)
                        {
                            tabletYesNo = true;
                            tabletGroupBox.Enabled = true;
                            tabletWarrantyRadioButton.Checked = true;
                        }

                        if (string.IsNullOrEmpty(userCart.ConsoleID) == false)
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
