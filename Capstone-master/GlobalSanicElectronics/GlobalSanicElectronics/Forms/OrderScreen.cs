using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class OrderScreen : Form
    {
        public OrderScreen()
        {
            InitializeComponent();       
        }

        double userPrice = 0;

        bool consoleYesNo;
        bool computerYesNo;
        bool tabletYesNo;
        bool televisionYesNo;
        

        public string orderFormUsername { get; set; }        
        public double overallPrice { get; set; }

        Cart userCart = new Cart();
        OrderScreenPartTwo orderScreenPartTwoForm = new OrderScreenPartTwo();

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.mainApplicationUsername = orderFormUsername;
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
            userPrice = DatabaseOperationsCart.DisplayCart(userCart, cartDataGridView, orderFormUsername, consoleTabControl,
                consoleBundleFourRadioButton, consoleWarrantyFourRadioButton, computerGroupBox,
                computerWarrantyFourRadioButton, tabletGroupBox, tabletWarrantyFourRadioButton, televisionGroupBox,
                televisionWarrantyFourRadioButton, consoleYesNo, computerYesNo, tabletYesNo, televisionYesNo, userPrice,
                orderScreenPartTwoForm);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
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
            orderScreenPartTwoForm.userName = orderFormUsername;            
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
