using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class EmployeeScreenForm : Form
    {
        public EmployeeScreenForm()
        {
            InitializeComponent();
        }

        //Declare variables
        string email;           //Hold the user's email

        private void updateRepairStatus_Click(object sender, EventArgs e)
        {
            //Make sure the username is not empty so the application can update the right fields
            if (string.IsNullOrEmpty(usernameTextBox.Text) == false)
            {
                //Set repair status to what employee has chosen in the combobox correlating with it
                string repairStatus = repairStatusComboBox.Text;

                //Call the UpdateRepairStatus method to update the information about the user's current repair
                DatabaseOperationsRepairs.UpdateRepairStatus(repairStatusComboBox, usernameTextBox, email, repairsDataGridView);

                //Call the email operations to email the user and let them know what there new repair status is
                EmailOperations.RepairStatus(repairStatus, email, usernameTextBox, repairStatusComboBox);

                //Call the updateRepairView that the employee can see so that they know it was updated accordingly
                DatabaseOperationsRepairs.UpdateRepairView(usernameTextBox, repairsDataGridView);
            }
            else
            {
                //If username is empty tell employee to enter a username
                MessageBox.Show("Please enter a username in to update the status");
            }
        }

        private void updateRefundButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) == false)
            {
                //Variable to hold what is in the combobox
                string refundStatus = refundStatusComboBox.Text;

                //Call the UpdateRefundStatus method to update the information about the user's current refund
                DatabaseOperationsRefunds.UpdateRefundStatus(refundStatusComboBox, usernameTextBox, email, refundsDataGridView);

                //Call the email operations to email the user and let them know what there new refund status is
                EmailOperations.RefundStatus(refundStatus, email, usernameTextBox, refundStatusComboBox);

                //Call the updateRefundView that the employee can see so that they know it was updated accordingly
                DatabaseOperationsRefunds.UpdateRefundView(usernameTextBox, refundsDataGridView);
            }
            else
            {
                //If username is empty tell employee to enter a username
                MessageBox.Show("Please enter a username in to update the status");
            }
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

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void EmployeeScreen_Load(object sender, EventArgs e)
        {
            DatabaseOperationsPurchases.LoadPurchases(purchasesDataGridView);
        }

        private void purchasesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void purchasesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void purchasesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void purchasesBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void loadCustomerInformationButton_Click(object sender, EventArgs e)
        {
            //Load all the information about the customer, repairs, refunds, and delivery for the employee to see
            DatabaseOperations.LoadCustomerInformation(usernameTextBox, purchasesDataGridView, refundsDataGridView, repairsDataGridView);
        }

        private void updateDeliveryStatusButton_Click(object sender, EventArgs e)
        {
            //Make sure that the username field is not empty
            if (string.IsNullOrEmpty(usernameTextBox.Text) == false)
            {
                string deliveryStatus = deliveryComboBox.Text;      //Set delivery status to what is in the delivery combo box that the employee has selected

                //Call the UpdateDeliveryStatus method to update the information about the user's current Delivery
                DatabaseOperations.UpdateDeliveryStatus(deliveryComboBox, usernameTextBox, email, purchasesDataGridView);

                //Call the email operations to email the user and let them know what there new delivery status is
                EmailOperations.DeliveryStatus(deliveryStatus, email, usernameTextBox, deliveryComboBox);

                //Call the updateRefundView that the employee can see so that they know it was updated accordingly
                DatabaseOperations.UpdateDeliveryView(usernameTextBox.Text, purchasesDataGridView);
            }
            else
            {
                //Tell the employee that the username must contain information
                MessageBox.Show("Please enter a username in to update the status");
            }
        }
    }
}
