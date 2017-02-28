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
                    //To hold the information from the selected Television row in the Directory and add it to the TelevisionSale structure                    
                    string televisionID = row.Cells[0].Value.ToString();
                    string brand = row.Cells[1].Value.ToString();
                    string size = row.Cells[2].Value.ToString();
                    string led = row.Cells[3].Value.ToString();
                    string smart = row.Cells[4].Value.ToString();
                    string resolution = row.Cells[5].Value.ToString();
                    string color = row.Cells[6].Value.ToString();
                    string price = row.Cells[7].Value.ToString();

                    MessageBox.Show(brand + " television has been added to your cart with the price of $" + price);

                    System.Data.SqlClient.SqlCommand addTelevisionToCartCommand = new System.Data.SqlClient.SqlCommand();
                    addTelevisionToCartCommand.CommandType = System.Data.CommandType.Text;
                    addTelevisionToCartCommand.CommandText = "INSERT into Cart (Username, Brand, Size, LED, Smart, Resolution, Color, Price) VALUES ('" + MyProperty + "' , '" + brand + "' , '" + size + "' , '" + led + "' , '" + smart + "' , '" + resolution + "' , '" + color + "' , '" + price + "')";
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
                    string tabletID = row.Cells[0].Value.ToString();
                    string brand = row.Cells[1].Value.ToString();
                    string size = row.Cells[2].Value.ToString();
                    string storage = row.Cells[3].Value.ToString();
                    string processor = row.Cells[4].Value.ToString();
                    string wifi = row.Cells[5].Value.ToString();
                    string color = row.Cells[6].Value.ToString();
                    string price = row.Cells[7].Value.ToString();

                    MessageBox.Show(brand + " tablet has been added to your cart with the price of $" + price);

                    System.Data.SqlClient.SqlCommand addTabletToCartCommand = new System.Data.SqlClient.SqlCommand();
                    addTabletToCartCommand.CommandType = System.Data.CommandType.Text;
                    addTabletToCartCommand.CommandText = "INSERT into Cart (Username, Brand, Size, Storage, Processor, Wifi, Color, Price) VALUES ('" + MyProperty + "' , '" + brand + "' , '" + size + "' , '" + storage + "' , '" + processor + "' , '" + wifi + "' , '" + color + "' , '" + price + "')";
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
                    string consoleID = row.Cells[0].Value.ToString();
                    string brand = row.Cells[1].Value.ToString();
                    string storage = row.Cells[2].Value.ToString();
                    string price = row.Cells[3].Value.ToString();

                    MessageBox.Show(brand + " console has been added to your cart with the price of $" + price);

                    System.Data.SqlClient.SqlCommand addConsoleToCartCommand = new System.Data.SqlClient.SqlCommand();
                    addConsoleToCartCommand.CommandType = System.Data.CommandType.Text;
                    addConsoleToCartCommand.CommandText = "INSERT into Cart (Username, Brand, Storage, Price) VALUES ('" + MyProperty + "' , '" + brand + "' , '" + storage + "' , '" + price + "')";
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
                    string computerID = row.Cells[0].Value.ToString();
                    string brand = row.Cells[1].Value.ToString();
                    string size = row.Cells[2].Value.ToString();
                    string processor = row.Cells[3].Value.ToString();
                    string storage = row.Cells[4].Value.ToString();
                    string ram = row.Cells[5].Value.ToString();
                    string color = row.Cells[6].Value.ToString();
                    string price = row.Cells[7].Value.ToString();

                    MessageBox.Show(brand + " computer has been added to your cart with the price of $" + price);

                    System.Data.SqlClient.SqlCommand addComputerToCartCommand = new System.Data.SqlClient.SqlCommand();
                    addComputerToCartCommand.CommandType = System.Data.CommandType.Text;
                    addComputerToCartCommand.CommandText = "INSERT into Cart (Username, Brand, Size, Processor, Storage, RAM, Color, Price) VALUES ('" + MyProperty + "' , '" + brand + "' , '" + size + "' , '" + processor + "' , '" + storage + "' , '" + ram + "' , '" + color + "' , '" + price + "')";
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
            string message = "WARNING: Going to the cart now means you will have to restart the entire client to update it. Are you sure you want to do this?";
            message += "\n\n";
            message += "If an item you added to your cart or is in your confirm puchase screen is not in your cart and you don't want to purchase the item, please restart the client to refresh your cart!";
            string caption = "Cart will not update until restart";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if(result == DialogResult.Yes)
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();


                //Go to the Cart Screen as user requested
                Cart cartForm = new Cart();
                cartForm.cartProperty = MyProperty;
                cartForm.Show();
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
    }
}
