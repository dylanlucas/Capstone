using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class OrderScreenForm : Form
    {
        public OrderScreenForm()
        {
            InitializeComponent();       
        }

        double userPrice = 0;       //Default the userPrice to 0 if no items in cart

        bool consoleYesNo;          //To help get information if they have a console in cart
        bool computerYesNo;         //To help get information if they have a computer in cart
        bool tabletYesNo;           //To help get information if they have a tablet in the cart
        bool televisionYesNo;       //To help get information if they have a television in the cart
        

        public string orderFormUsername { get; set; }     //Hold the username of the user   
        public double overallPrice { get; set; }          //Hold the user's overall price of items in cart

        Cart userCart = new Cart();                     //Create a userCart object for the Cart
        OrderScreenPartTwoForm orderScreenPartTwoForm = new OrderScreenPartTwoForm();       //Create a new form for the orderscreen

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplicationForm mainApplicationForm = new MainApplicationForm();
            mainApplicationForm.mainApplicationUsername = orderFormUsername;            //Send the username of the user to the main application
            mainApplicationForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the entire application
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void cartBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            //Get the user price from the DisplayCart information in the DatabaseOperations class
            userPrice = DatabaseOperationsCart.DisplayCart(userCart, cartDataGridView, orderFormUsername, consoleTabControl,
                consoleBundleFourRadioButton, consoleWarrantyFourRadioButton, computerGroupBox,
                computerWarrantyFourRadioButton, tabletGroupBox, tabletWarrantyFourRadioButton, televisionGroupBox,
                televisionWarrantyFourRadioButton, consoleYesNo, computerYesNo, tabletYesNo, televisionYesNo, userPrice,
                orderScreenPartTwoForm);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //Get the user price from the DisplayCart information in the GeneralOperations class
            userPrice = GeneralOperations.UserPrice(consoleBundleOneRadioButton, consoleBundleTwoRadioButton, consoleBundleThreeRadioButton,
                consoleWarrantyOneRadioButton, consoleWarrantyTwoRadioButton, consoleWarrantyThreeRadioButton,
                computerWarrantyOneRadioButton, computerWarrantyTwoRadioButton, computerWarrantyThreeRadioButton,
                tabletWarrantyOneRadioButton, tabletWarrantyTwoRadioButton, tabletWarrantyThreeRadioButton,
                televisionWarrantyOneRadioButton, televisionWarrantyTwoRadioButton, televisionWarrantyThreeRadioButton,
                userPrice);

            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            orderScreenPartTwoForm.userPrice = userPrice;
            orderScreenPartTwoForm.userName = orderFormUsername;        //Send the username of the user to the OrderForm           
            orderScreenPartTwoForm.Show();
        }

        private void cartBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void cartBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void cartBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void cartBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }
    }
}
