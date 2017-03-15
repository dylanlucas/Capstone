using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class UserCart : Form
    {
        public UserCart()
        {
            InitializeComponent(); 
        }

        public string cartFormUsername { get; set; }

        Cart userCart = new Cart();     

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(cartDataGridView.SelectedRows.Count > 0)
            {
                DatabaseOperationsCart.RemoveItem(userCart, cartDataGridView, cartTableAdapter, gSEDatabaseDataSet);
            }
            else
            {
                MessageBox.Show("Please select a row to delete from your cart!");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {            
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();            

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.mainApplicationUsername = cartFormUsername;
            mainApplicationForm.Show();
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

        private void Cart_Load(object sender, EventArgs e)
        {
            userCart.Username = cartFormUsername;

            DatabaseOperationsCart.ShowCart(userCart, cartFormUsername, cartDataGridView);
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
