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
        struct TelevisionSale
        {
            //To hold the information from the selected Television row in the Directory
            public string tvID;
            public string tvBrand;
            public string tvSize;
            public string tvLED;
            public string tvSmart;
            public string tvResolution;
            public string tvColor;
            public string tvPrice;
        }

        struct ConsoleSale
        {
            //To hold the information from the selected Console row in the Directory
            public string consoleID;
            public string consoleBrand;
            public string consoleStorage;
            public string consolePrice;
        }

        struct TabletSale
        {
            //To hold the information from the selected Tablet row in the Directory
            public string tabletID;
            public string tabletBrand;
            public string tabletSize;
            public string tabletStorage;
            public string tabletProcessor;
            public string tabletWifi;
            public string tabletColor;
            public string tabletPrice;
        }

        struct ComputerSale
        {
            //To hold the information from the selected Computer row in the Directory
            public string computerID;
            public string computerBrand;
            public string computerSize;
            public string computerProcessor;
            public string computerStorage;
            public string computerRam;
            public string computerColor;
            public string computerPrice; 
        }

        //Create a List as a field for TelevisionSale, ConsoleSale, Tablets, and Computers
        private List<TelevisionSale> tvList = new List<TelevisionSale>();
        private List<ConsoleSale> consoleList = new List<ConsoleSale>();
        private List<TabletSale> tabletList = new List<TabletSale>();
        private List<ComputerSale> computerList = new List<ComputerSale>();

        //Variables
        int cart;           //To show the user how many items they have currently added to there cart
        double overallPrice;       //To show the user how much there current cart is

        public MainApplication()
        {
            InitializeComponent();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (televisionDirectoryDataGridView.Visible == true)
            {
                //Create an instance of the TelevisionSale structure
                TelevisionSale tv = new TelevisionSale();

                foreach (DataGridViewRow row in televisionDirectoryDataGridView.SelectedRows)
                {
                    //To hold the information from the selected Television row in the Directory and add it to the TelevisionSale structure                    
                    string televisionID = row.Cells[0].Value.ToString();
                    tv.tvID = televisionID;

                    string brand = row.Cells[1].Value.ToString();
                    tv.tvBrand = brand;

                    string size = row.Cells[2].Value.ToString();
                    tv.tvSize = size;

                    string led = row.Cells[3].Value.ToString();
                    tv.tvLED = led;

                    string smart = row.Cells[4].Value.ToString();
                    tv.tvSmart = smart;

                    string resolution = row.Cells[5].Value.ToString();
                    tv.tvResolution = resolution;

                    string color = row.Cells[6].Value.ToString();
                    tv.tvColor = color;

                    string price = row.Cells[7].Value.ToString();
                    tv.tvPrice = price;

                    tvList.Add(tv);

                    MessageBox.Show(brand + " television has been added to your cart with the price of $" + price);

                    //Increment the cart as a new item has been added to it
                    cart++;

                    //Display the new cart total to the user
                    cartItemsTextLabel.Text = cart.ToString();

                    //Increment the price as a new item has been added to the cart
                    overallPrice += double.Parse(price);

                    //Display the new price total to the user
                    priceDisplayLabel.Text = overallPrice.ToString();
                }
            }

            if (consoleDirectoryDataGridView.Visible == true)
            {
                //Create an instance of the ConsoleSale structure
                ConsoleSale console = new ConsoleSale();

                foreach (DataGridViewRow row in consoleDirectoryDataGridView.SelectedRows)
                {
                    //To hold the information from the selected Console row in the Directory
                    string consoleIdentification = row.Cells[0].Value.ToString();
                    console.consoleID = consoleIdentification;

                    string brand = row.Cells[1].Value.ToString();
                    console.consoleBrand = brand;

                    string storage = row.Cells[2].Value.ToString();
                    console.consoleStorage = storage;

                    string price = row.Cells[3].Value.ToString();
                    console.consolePrice = price;

                    consoleList.Add(console);

                    MessageBox.Show(brand + " console has been added to your cart with the price of $" + price);

                    //Increment the cart as a new item has been added to it
                    cart++;

                    //Display the new cart total to the user
                    cartItemsTextLabel.Text = cart.ToString();

                    //Increment the price as a new item has been added to the cart
                    overallPrice += double.Parse(price);

                    //Display the new price total to the user
                    priceDisplayLabel.Text = overallPrice.ToString();
                }
            }

            if (tabletDirectorDataGridView.Visible == true)
            {
                TabletSale tablet = new TabletSale();

                foreach (DataGridViewRow row in tabletDirectorDataGridView.SelectedRows)
                {
                    //To hold the information from the selected Tablet row in the Directory
                    string tabletIdentification = row.Cells[0].Value.ToString();
                    tablet.tabletID = tabletIdentification;
                    
                    string brand = row.Cells[1].Value.ToString();
                    tablet.tabletBrand = brand;

                    string size = row.Cells[2].Value.ToString();
                    tablet.tabletSize = size;

                    string storage = row.Cells[3].Value.ToString();
                    tablet.tabletStorage = storage;

                    string processor = row.Cells[4].Value.ToString();
                    tablet.tabletProcessor = processor;

                    string wifi = row.Cells[5].Value.ToString();
                    tablet.tabletWifi = wifi;

                    string color = row.Cells[6].Value.ToString();
                    tablet.tabletColor = color;

                    string price = row.Cells[7].Value.ToString();
                    tablet.tabletPrice = price;

                    tabletList.Add(tablet);

                    MessageBox.Show(brand + " tablet has been added to your cart with the price of $" + price);

                    //Increment the cart as a new item has been added to it
                    cart++;

                    //Display the new cart total to the user
                    cartItemsTextLabel.Text = cart.ToString();

                    //Increment the price as a new item has been added to the cart
                    overallPrice += double.Parse(price);

                    //Display the new price total to the user
                    priceDisplayLabel.Text = overallPrice.ToString();
                }
            }

            if (computerDirectoryDataGridView.Visible == true)
            {
                ComputerSale computer = new ComputerSale();

                foreach (DataGridViewRow row in computerDirectoryDataGridView.SelectedRows)
                {
                    //To hold the information from the selected Computer row in the Directory
                    string computerIdentification = row.Cells[0].Value.ToString();
                    computer.computerID = computerIdentification;

                    string brand = row.Cells[1].Value.ToString();
                    computer.computerBrand = brand;

                    string size = row.Cells[2].Value.ToString();
                    computer.computerSize = size;

                    string processor = row.Cells[3].Value.ToString();
                    computer.computerProcessor = processor;

                    string storage = row.Cells[4].Value.ToString();
                    computer.computerStorage = storage;

                    string ram = row.Cells[5].Value.ToString();
                    computer.computerRam = ram;

                    string color = row.Cells[6].Value.ToString();
                    computer.computerColor = color;

                    string price = row.Cells[7].Value.ToString();
                    computer.computerPrice = price;

                    computerList.Add(computer);

                    MessageBox.Show(brand + " computer has been added to your cart with the price of $" + price);

                    //Increment the cart as a new item has been added to it
                    cart++;

                    //Display the new cart total to the user
                    cartItemsTextLabel.Text = cart.ToString();

                    //Increment the price as a new item has been added to the cart
                    overallPrice += double.Parse(price);

                    //Display the new price total to the user
                    priceDisplayLabel.Text = overallPrice.ToString();
                }
            }
        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the Cart Screen as user requested
            Cart cartForm = new Cart();
            cartForm.Show();
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
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Allow the user to get contact information about the company incase needed and as they clicked the button they have requested to go here
            ContactScreen contactScreenForm = new ContactScreen();
            contactScreenForm.Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Allow the user go to the order screen, IF the cart is equal to or greater than 1
            OrderScreen orderScreenForm = new OrderScreen();
            orderScreenForm.Show();
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
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TabletDirector' table. You can move, or remove it, as needed.
            this.tabletDirectorTableAdapter.Fill(this.gSEDatabaseDataSet.TabletDirector);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.ConsoleDirectory' table. You can move, or remove it, as needed.
            this.consoleDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.ConsoleDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TelevisionDirectory' table. You can move, or remove it, as needed.
            this.televisionDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.TelevisionDirectory);

        }
    }
}
