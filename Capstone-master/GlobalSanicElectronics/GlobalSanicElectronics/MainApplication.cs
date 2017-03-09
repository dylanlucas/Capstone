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
using System.IO;

namespace GlobalSanicElectronics
{
    public partial class MainApplication : Form
    {
        public MainApplication()
        {
            InitializeComponent();
        }

        //Declare variable for Database
        System.Data.SqlClient.SqlConnection sqlConnectionLink =
            new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dylan\\Source\\Repos\\Capstone\\Capstone-master\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True");
                                                   

        public string MyProperty { get; set; }

        private void addToCartButton_Click(object sender, EventArgs e)
        {        
            if (televisionDirectoryDataGridView.Visible == true)
            {
                foreach (DataGridViewRow row in televisionDirectoryDataGridView.SelectedRows)
                {
                    //To hold information about the Television and input it into the Cart table in the database                    
                    string televisionID = row.Cells[0].Value.ToString();
                    string brand = row.Cells[1].Value.ToString();
                    string size = row.Cells[2].Value.ToString();
                    string led = row.Cells[3].Value.ToString();
                    string smart = row.Cells[4].Value.ToString();
                    string resolution = row.Cells[5].Value.ToString();
                    string color = row.Cells[6].Value.ToString();
                    string price = row.Cells[7].Value.ToString();

                    //Strings to tell the cart table in the database whether the item is a Computer, Console, Tablet, or Television
                    string television = "Yes";
                    string console = "No";
                    string tablet = "No";
                    string computer = "No";

                    MessageBox.Show(brand + " television has been added to your cart with the price of $" + price);

                    //Set up the Command type so the program can input into the database
                    System.Data.SqlClient.SqlCommand addTelevisionToCartCommand = new System.Data.SqlClient.SqlCommand();
                    addTelevisionToCartCommand.CommandType = System.Data.CommandType.Text;
                    addTelevisionToCartCommand.CommandText = "INSERT into Cart (Username, Computer, Console, Tablet, Television, Brand, Size, LED, Smart, Resolution, Color, Price) VALUES ('" 
                        + MyProperty + "' , '" + computer + "' , '" + console + "' , '" + tablet + "' , '" + television + "' , '" + brand + "' , '" + size + "' , '" + led + "' , '" + smart + "' , '" + resolution 
                        + "' , '" + color + "' , '" + price + "')";

                    //Establish a connection to the database and perform the addTelevisionToCartCommand
                    addTelevisionToCartCommand.Connection = sqlConnectionLink;
                    sqlConnectionLink.Open();
                    addTelevisionToCartCommand.ExecuteNonQuery();
                    sqlConnectionLink.Close();
                }
            }

            else if (tabletDirectorDataGridView.Visible == true)
            {
                foreach (DataGridViewRow row in tabletDirectorDataGridView.SelectedRows)
                {
                    //To hold information about the Tablets and input it into the Cart table in the database
                    string tabletID = row.Cells[0].Value.ToString();
                    string brand = row.Cells[1].Value.ToString();
                    string size = row.Cells[2].Value.ToString();
                    string storage = row.Cells[3].Value.ToString();
                    string processor = row.Cells[4].Value.ToString();
                    string wifi = row.Cells[5].Value.ToString();
                    string color = row.Cells[6].Value.ToString();
                    string price = row.Cells[7].Value.ToString();

                    //Strings to tell the cart table in the database whether the item is a Computer, Console, Tablet, or Television
                    string television = "No";
                    string console = "No";
                    string tablet = "Yes";
                    string computer = "No";

                    MessageBox.Show(brand + " tablet has been added to your cart with the price of $" + price);

                    //Set up the Command type so the program can input into the database
                    System.Data.SqlClient.SqlCommand addTabletToCartCommand = new System.Data.SqlClient.SqlCommand();
                    addTabletToCartCommand.CommandType = System.Data.CommandType.Text;
                    addTabletToCartCommand.CommandText = "INSERT into Cart (Username, Computer, Console, Tablet, Television, Brand, Size, Storage, Processor, Wifi, Color, Price) VALUES ('" 
                        + MyProperty + "' , '" + computer + "' , '" + console + "' , '" + tablet + "' , '" + television + "' , '" + brand + "' , '" + size + "' , '" + storage + "' , '" 
                        + processor + "' , '" + wifi + "' , '" + color + "' , '" + price + "')";

                    //Establish a connection to the database and perform the addTabletToCartCommand
                    addTabletToCartCommand.Connection = sqlConnectionLink;
                    sqlConnectionLink.Open();
                    addTabletToCartCommand.ExecuteNonQuery();
                    sqlConnectionLink.Close();
                }
            }

            else if (consoleDirectoryDataGridView.Visible == true)
            {
                foreach (DataGridViewRow row in consoleDirectoryDataGridView.SelectedRows)
                {
                    //To hold information about the Consoles and input it into the Cart table in the database
                    string consoleID = row.Cells[0].Value.ToString();
                    string brand = row.Cells[1].Value.ToString();
                    string storage = row.Cells[2].Value.ToString();
                    string price = row.Cells[3].Value.ToString();

                    //Strings to tell the cart table in the database whether the item is a Computer, Console, Tablet, or Television
                    string television = "No";
                    string console = "Yes";
                    string tablet = "No";
                    string computer = "No";

                    MessageBox.Show(brand + " console has been added to your cart with the price of $" + price);

                    //Set up the Command type so the program can input into the database
                    System.Data.SqlClient.SqlCommand addConsoleToCartCommand = new System.Data.SqlClient.SqlCommand();
                    addConsoleToCartCommand.CommandType = System.Data.CommandType.Text;
                    addConsoleToCartCommand.CommandText = "INSERT into Cart (Username, Computer, Console, Tablet, Television, Brand, Storage, Price) VALUES ('" 
                        + MyProperty + "' , '" + computer + "' , '" + console + "' , '" + tablet + "' , '" + television + "' , '" + brand + "' , '" 
                        + storage + "' , '" + price + "')";

                    //Establish a connection to the database and perform the addConsoleToCartCommand
                    addConsoleToCartCommand.Connection = sqlConnectionLink;
                    sqlConnectionLink.Open();
                    addConsoleToCartCommand.ExecuteNonQuery();
                    sqlConnectionLink.Close();
                }
            }

            else if (computerDirectoryDataGridView.Visible == true)
            {
                foreach (DataGridViewRow row in computerDirectoryDataGridView.SelectedRows)
                {
                    //To hold information about the Compouters and input it into the Cart table in the database
                    string computerID = row.Cells[0].Value.ToString();
                    string brand = row.Cells[1].Value.ToString();
                    string size = row.Cells[2].Value.ToString();
                    string processor = row.Cells[3].Value.ToString();
                    string storage = row.Cells[4].Value.ToString();
                    string ram = row.Cells[5].Value.ToString();
                    string color = row.Cells[6].Value.ToString();
                    string price = row.Cells[7].Value.ToString();

                    //Strings to tell the cart table in the database whether the item is a Computer, Console, Tablet, or Television
                    string television = "No";
                    string console = "No";
                    string tablet = "No";
                    string computer = "Yes";

                    MessageBox.Show(brand + " computer has been added to your cart with the price of $" + price);

                    //Set up the Command type so the program can input into the database
                    System.Data.SqlClient.SqlCommand addComputerToCartCommand = new System.Data.SqlClient.SqlCommand();
                    addComputerToCartCommand.CommandType = System.Data.CommandType.Text;
                    addComputerToCartCommand.CommandText = "INSERT into Cart (Username, Computer, Console, Tablet, Television, Brand, Size, Processor, Storage, RAM, Color, Price) VALUES ('" 
                        + MyProperty + "' , '" + computer + "' , '" + console + "' , '" + tablet + "' , '" + television + "' , '" 
                        + brand + "' , '" + size + "' , '" + processor + "' , '" + storage + "' , '" + ram + "' , '" + color + "' , '" + price + "')";

                    //Establish a connection to the database and perform the addComputerToCartCommand
                    addComputerToCartCommand.Connection = sqlConnectionLink;
                    sqlConnectionLink.Open();
                    addComputerToCartCommand.ExecuteNonQuery();
                    sqlConnectionLink.Close();
                }
            }

            this.Refresh();
        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            //Declare variable for Database
            System.Data.SqlClient.SqlConnection sqlConnectionLink =
                new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dylan\\Source\\Repos\\Capstone\\Capstone-master\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True");

            //Declare Variables
            Int32 verifyCart;

            //Check for username & Password
            String validation = "SELECT * From Cart WHERE Username= '" + MyProperty + "'";
            SqlCommand validateInputCommand = new SqlCommand(validation, sqlConnectionLink);
            sqlConnectionLink.Open();
            verifyCart = Convert.ToInt32(validateInputCommand.ExecuteScalar());
            sqlConnectionLink.Close();

            if (verifyCart > 0)
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();


                //Go to the Cart Screen as user requested
                Cart cartForm = new Cart();
                cartForm.cartProperty = MyProperty;
                cartForm.Show();
            }
            else
            {
                MessageBox.Show("Nothing is currently in your cart!");
            }
        }

        private void repairsButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the RepairScreenForm as the user has requested it to allow the user with some options available in that category
            RepairScreen repairScreenForm = new RepairScreen();
            repairScreenForm.Show();
        }

        private void returnsButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the ReturnScreen as the user has requested it to allow the user with some options available in that category
            ReturnScreen returnScreenForm = new ReturnScreen();
            returnScreenForm.Show();
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

        private void contactButton_Click(object sender, EventArgs e)
        {           
            //Allow the user to get contact information about the company incase needed and as they clicked the button they have requested to go here
            ContactScreen contactScreenForm = new ContactScreen();
            contactScreenForm.Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //Declare variable for Database
            System.Data.SqlClient.SqlConnection sqlConnectionLink =
                new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dylan\\Source\\Repos\\Capstone\\Capstone-master\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True");

            //Declare Variables
            Int32 verifyCart;

            //Check for username & Password
            String validation = "SELECT * From Cart WHERE Username= '" + MyProperty + "'";
            SqlCommand validateInputCommand = new SqlCommand(validation, sqlConnectionLink);
            sqlConnectionLink.Open();
            verifyCart = Convert.ToInt32(validateInputCommand.ExecuteScalar());
            sqlConnectionLink.Close();

            if (verifyCart > 0)
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();

                //Allow the user go to the order screen, IF the cart is equal to or greater than 1
                OrderScreen orderScreenForm = new OrderScreen();
                orderScreenForm.orderProperty = MyProperty;
                orderScreenForm.Show();
            }
            else
            {
                MessageBox.Show("Nothing in cart to purchase!");
            }
        }

        private void televisionButton_Click(object sender, EventArgs e)
        {
            //Set this directory to be visible
            televisionDirectoryDataGridView.Visible = true;
            addToCartButton.Enabled = true;

            //All other directors to be invisible
            consoleDirectoryDataGridView.Visible = false;
            tabletDirectorDataGridView.Visible = false;
            computerDirectoryDataGridView.Visible = false;
        }

        private void consoleButton_Click(object sender, EventArgs e)
        {
            //Set this directory to be visible
            consoleDirectoryDataGridView.Visible = true;
            addToCartButton.Enabled = true;

            //All other directors to be invisible
            televisionDirectoryDataGridView.Visible = false;
            tabletDirectorDataGridView.Visible = false;
            computerDirectoryDataGridView.Visible = false;
        }

        private void tabletButton_Click(object sender, EventArgs e)
        {
            //Set this directory to be visible
            tabletDirectorDataGridView.Visible = true;
            addToCartButton.Enabled = true;

            //All other directors to be invisible
            televisionDirectoryDataGridView.Visible = false;
            consoleDirectoryDataGridView.Visible = false;
            computerDirectoryDataGridView.Visible = false;
        }

        private void computerButton_Click(object sender, EventArgs e)
        {
            //Set this directory to be visible
            computerDirectoryDataGridView.Visible = true;
            addToCartButton.Enabled = true;

            //All other directors to be invisible
            televisionDirectoryDataGridView.Visible = false;
            consoleDirectoryDataGridView.Visible = false;
            tabletDirectorDataGridView.Visible = false;
        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void MainApplication_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.ComputerDirectory' table. You can move, or remove it, as needed.
            this.computerDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.ComputerDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.ConsoleDirectory' table. You can move, or remove it, as needed.
            this.consoleDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.ConsoleDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TabletDirector' table. You can move, or remove it, as needed.
            this.tabletDirectorTableAdapter.Fill(this.gSEDatabaseDataSet.TabletDirector);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TelevisionDirectory' table. You can move, or remove it, as needed.
            this.televisionDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.TelevisionDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.ComputerDirectory' table. You can move, or remove it, as needed.
            this.computerDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.ComputerDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.ConsoleDirectory' table. You can move, or remove it, as needed.
            this.consoleDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.ConsoleDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TabletDirector' table. You can move, or remove it, as needed.
            this.tabletDirectorTableAdapter.Fill(this.gSEDatabaseDataSet.TabletDirector);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TelevisionDirectory' table. You can move, or remove it, as needed.
            this.televisionDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.TelevisionDirectory);

        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void computerDirectoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.computerDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void priceDisplayLabel_Click(object sender, EventArgs e)
        {

        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click_5(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void trackOrderButton_Click(object sender, EventArgs e)
        {
            //Declare variable for Database
            System.Data.SqlClient.SqlConnection sqlConnectionLink =
                new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dylan\\Source\\Repos\\Capstone\\Capstone-master\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True");

            //Declare Variables
            Int32 verifyPurchases;

            //Check for username & Password
            String validation = "SELECT * From Purchases WHERE CustomerName= '" + MyProperty + "'";
            SqlCommand validateInputCommand = new SqlCommand(validation, sqlConnectionLink);
            sqlConnectionLink.Open();
            verifyPurchases = Convert.ToInt32(validateInputCommand.ExecuteScalar());
            sqlConnectionLink.Close();

            if (verifyPurchases > 0)
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();

                TrackOrder trackOrderForm = new TrackOrder();
                trackOrderForm.orderUsername = MyProperty;
                trackOrderForm.Show();
            }
            else
            {
                MessageBox.Show("No orders currently being processed or delivered!");
            }
        }
    }
}
