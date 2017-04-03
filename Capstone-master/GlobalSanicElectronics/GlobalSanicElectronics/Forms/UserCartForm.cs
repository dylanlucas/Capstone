using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class UserCartForm : Form
    {
        public UserCartForm()
        {
            InitializeComponent(); 
        }

        public string cartFormUsername { get; set; }

        Cart userCart = new Cart();     

        private void removeButton_Click(object sender, EventArgs e)
        {
            //Method to make sure that at least more than 0 row's are selected
            if(cartDataGridView.SelectedRows.Count > 0)
            {
                //Method to remove items from the carts
                DatabaseOperationsCart.RemoveItem(userCart, cartDataGridView, cartTableAdapter, gSEDatabaseDataSet);
            }
            else
            {
                //Send message to the user that they must select information to get deleted
                MessageBox.Show("Please select a row to delete from your cart!");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {            
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();            

            //Go back to the Main Application since the user has requested to
            MainApplicationForm mainApplicationForm = new MainApplicationForm();
            mainApplicationForm.mainApplicationUsername = cartFormUsername;             //Send the username of the user to the cartForm
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
