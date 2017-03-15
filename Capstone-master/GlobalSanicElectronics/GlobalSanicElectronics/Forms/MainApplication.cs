using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class MainApplication : Form
    {        
        public MainApplication()
        {
            InitializeComponent();            
        }

        public string mainApplicationUsername { get; set; }

        TelevisionDirectory TV = new TelevisionDirectory();
        TabletDirectory Tablet = new TabletDirectory();
        ConsoleDirectory Console = new ConsoleDirectory();
        ComputerDirectory Computer = new ComputerDirectory();
        Cart userCart = new Cart();
        Purchases userPurchases = new Purchases();

        private void addToCartButton_Click(object sender, EventArgs e)
        {        
            if (televisionDirectoryDataGridView.Visible == true)
            {
                DatabaseOperationsCart.TelevisionCart(TV, televisionDirectoryDataGridView, mainApplicationUsername);
                userCart.Televisions.Add(TV);
            }

            else if (tabletDirectorDataGridView.Visible == true)
            {
                DatabaseOperationsCart.TabletCart(Tablet, tabletDirectorDataGridView, mainApplicationUsername);
                userCart.Tablets.Add(Tablet);
            }

            else if (consoleDirectoryDataGridView.Visible == true)
            {
                DatabaseOperationsCart.ConsoleCart(Console, consoleDirectoryDataGridView, mainApplicationUsername);
                userCart.Consoles.Add(Console);
            }

            else if (computerDirectoryDataGridView.Visible == true)
            {
                DatabaseOperationsCart.ComputerCart(Computer, computerDirectoryDataGridView, mainApplicationUsername);
                userCart.Computers.Add(Computer);
            }

            //Display the Cart Item Total for the User
            DatabaseOperationsCart.CartDisplay(userCart, mainApplicationUsername, cartDisplayLabel);

            //Display the Cart Price Total for the User
            DatabaseOperationsCart.CartPrice(userCart, mainApplicationUsername, cartPriceDisplayLabel);
        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            if (DatabaseOperationsCart.CartValidation(userCart, mainApplicationUsername))
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();


                //Go to the Cart Screen as user requested
                UserCart cartForm = new UserCart();
                cartForm.cartFormUsername = mainApplicationUsername;
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
            repairScreenForm.repairScreenFormUsername = mainApplicationUsername;
            repairScreenForm.Show();
        }

        private void returnsButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the ReturnScreen as the user has requested it to allow the user with some options available in that category
            ReturnScreen returnScreenForm = new ReturnScreen();
            returnScreenForm.refundScreenFormUsername = mainApplicationUsername;
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
            string message = "Does your cart contain all the items you would like to purchase? If so continue, if not please go back and remove items or add items";
            string caption = "Confirm Cart";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {               
                if (DatabaseOperationsCart.CartValidation(userCart, mainApplicationUsername))
                {
                    //Hide this form so the user can no longer see it as it is no longer needed
                    this.Hide();

                    //Allow the user go to the order screen, IF the cart is equal to or greater than 1
                    OrderScreen orderScreenForm = new OrderScreen();
                    orderScreenForm.orderFormUsername = mainApplicationUsername;
                    orderScreenForm.Show();
                }
                else
                {
                    MessageBox.Show("Nothing in cart to purchase!");
                }
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
            if (DatabaseOperationsPurchases.TrackOrder(userPurchases, mainApplicationUsername))
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();

                TrackOrder trackOrderForm = new TrackOrder();
                trackOrderForm.orderUsername = mainApplicationUsername;
                trackOrderForm.Show();
            }
            else
            {
                MessageBox.Show("No orders currently being processed or delivered!");
            }
        }

        private void computerDirectoryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.computerDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click_6(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click_7(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click_8(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void computerDirectoryBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.computerDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void MainApplication_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TelevisionDirectory' table. You can move, or remove it, as needed.
            this.televisionDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.TelevisionDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TelevisionDirectory' table. You can move, or remove it, as needed.
            this.televisionDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.TelevisionDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TelevisionDirectory' table. You can move, or remove it, as needed.
            this.televisionDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.TelevisionDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TabletDirector' table. You can move, or remove it, as needed.
            this.tabletDirectorTableAdapter.Fill(this.gSEDatabaseDataSet.TabletDirector);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.ConsoleDirectory' table. You can move, or remove it, as needed.
            this.consoleDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.ConsoleDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.ComputerDirectory' table. You can move, or remove it, as needed.
            this.computerDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.ComputerDirectory);

            //Display the Cart Item Total for the User
            DatabaseOperationsCart.CartDisplay(userCart, mainApplicationUsername, cartDisplayLabel);

            //Display the Cart Price Total for the User
            DatabaseOperationsCart.CartPrice(userCart, mainApplicationUsername, cartPriceDisplayLabel);
        }
    }
}