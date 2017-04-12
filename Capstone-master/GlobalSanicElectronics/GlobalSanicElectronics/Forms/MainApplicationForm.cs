using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class MainApplicationForm : Form
    {        
        public MainApplicationForm()
        {
            InitializeComponent();            
        }

        public string mainApplicationUsername { get; set; }

        TelevisionDirectory TV = new TelevisionDirectory();             //Create a Telvision Directory object for TV's
        TabletDirectory Tablet = new TabletDirectory();                 //Create a Tablet Directory object for Tablet's
        ConsoleDirectory Console = new ConsoleDirectory();              //Create a Console Directory object for Console's
        ComputerDirectory Computer = new ComputerDirectory();           //Create a Computer Directory object for Computer's
        Cart userCart = new Cart();                                     //Create a Cart object for user's cart
        Purchases userPurchases = new Purchases();                      //Create a Purchase object for user's purchase's

        private void addToCartButton_Click(object sender, EventArgs e)
        {        
            //If the Television directory is visible then add information about the TV to the cart
            if (televisionDirectoryDataGridView.Visible == true)
            {
                //Call the database operation for stuff relating to the Television
                DatabaseOperationsCart.TelevisionCart(TV, televisionDirectoryDataGridView, mainApplicationUsername);
                userCart.Televisions.Add(TV);       //Add TV information to the cart
            }

            //If the Tablet directory is visible then add information about the Tablet to the cart
            else if (tabletDirectorDataGridView.Visible == true)
            {
                //Call the database operation for stuff relating to the Tablet
                DatabaseOperationsCart.TabletCart(Tablet, tabletDirectorDataGridView, mainApplicationUsername);
                userCart.Tablets.Add(Tablet);       //Add Tablet information to the cart
            }

            //If the Console directory is visible then add information about the Console to the cart
            else if (consoleDirectoryDataGridView.Visible == true)
            {
                //Call the database operation for stuff relating to the Console
                DatabaseOperationsCart.ConsoleCart(Console, consoleDirectoryDataGridView, mainApplicationUsername);
                userCart.Consoles.Add(Console);     //Add Console information to the cart
            }

            //If Computer directory is visible then add information about the Computer to the cart
            else if (computerDirectoryDataGridView.Visible == true)
            {
                //Call the database operation for stuff relating to the Computer
                DatabaseOperationsCart.ComputerCart(Computer, computerDirectoryDataGridView, mainApplicationUsername);
                userCart.Computers.Add(Computer);       //Add Computer information to the cart
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
                UserCartForm cartForm = new UserCartForm();
                cartForm.cartFormUsername = mainApplicationUsername;        //Send the username of the user back to the main form
                cartForm.Show();
            }
            else
            {
                //Send a message to tell the user that there is nothing in there cart so no reason to go to the cart
                MessageBox.Show("Nothing is currently in your cart!");
            }
        }

        private void repairsButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the RepairScreenForm as the user has requested it to allow the user with some options available in that category
            RepairScreenForm repairScreenForm = new RepairScreenForm();
            repairScreenForm.repairScreenFormUsername = mainApplicationUsername;        //Send the username of the user to the repair form
            repairScreenForm.Show();
        }

        private void returnsButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the ReturnScreen as the user has requested it to allow the user with some options available in that category
            ReturnScreenForm returnScreenForm = new ReturnScreenForm();
            returnScreenForm.refundScreenFormUsername = mainApplicationUsername;        //Send the username of the user to the refund form
            returnScreenForm.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //As user has opted to log out, take them back to Launch Screen giving them the option to resign in or close out of the application completely from there
            LaunchScreenForm launchScreenForm = new LaunchScreenForm();
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
            ContactScreenForm contactScreenForm = new ContactScreenForm();
            contactScreenForm.contactScreenUsernameHolder = mainApplicationUsername;        //Send the usenramea of the user to the Contact screen
            contactScreenForm.Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //Message to let the user know that this is the cart they are purchasing and they need to change it if they don't want an item in the cart form
            string message = "Does your cart contain all the items you would like to purchase? If so continue, if not please go back and remove items or add items";
            //Message to confirm the cart
            string caption = "Confirm Cart";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;        //Create buttons for the MessageBox
            DialogResult result;        //For the if statement depending on the messagebox selection

            //set Result to what is correlating in the if statement
            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            //If the user says that they like the items in there cart go through this method
            if (result == DialogResult.Yes)
            {               
                //Call the CartValidation method to make sure that the user has a cart
                if (DatabaseOperationsCart.CartValidation(userCart, mainApplicationUsername))
                {
                    //Hide this form so the user can no longer see it as it is no longer needed
                    this.Hide();

                    //Allow the user go to the order screen, IF the cart is equal to or greater than 1
                    OrderScreenForm orderScreenForm = new OrderScreenForm();
                    orderScreenForm.orderFormUsername = mainApplicationUsername;        //Send the username of the user to the order screen
                    orderScreenForm.Show();
                }
                else
                {
                    //Tell the user that there is nothing in there cart to purchase
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

                TrackOrderForm trackOrderForm = new TrackOrderForm();
                trackOrderForm.orderUsername = mainApplicationUsername;     //Send the username of the user to the Track Order form
                trackOrderForm.Show();
            }
            else
            {
                //Tell the user that they have no orders that have been delivered or processed
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