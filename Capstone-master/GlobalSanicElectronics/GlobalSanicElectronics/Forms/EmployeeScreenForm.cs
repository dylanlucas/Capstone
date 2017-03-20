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
            if (string.IsNullOrEmpty(usernameTextBox.Text) == false)
            {
                string repairStatus = repairStatusComboBox.Text;

                DatabaseOperationsRepairs.UpdateRepairStatus(repairStatusComboBox, usernameTextBox, email, repairsDataGridView);

                EmailOperations.RepairStatus(repairStatus, email, usernameTextBox, repairStatusComboBox);

                DatabaseOperationsRepairs.UpdateRepairView(usernameTextBox, repairsDataGridView);
            }
            else
            {
                MessageBox.Show("Please enter a username in to update the status");
            }
        }

        private void updateRefundButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) == false)
            {
                //Variable to hold what is in the combobox
                string refundStatus = refundStatusComboBox.Text;

                DatabaseOperationsRefunds.UpdateRefundStatus(refundStatusComboBox, usernameTextBox, email, refundsDataGridView);

                EmailOperations.RefundStatus(refundStatus, email, usernameTextBox, refundStatusComboBox);

                DatabaseOperationsRefunds.UpdateRefundView(usernameTextBox, refundsDataGridView);
            }
            else
            {
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
            DatabaseOperations.LoadCustomerInformation(usernameTextBox, purchasesDataGridView, refundsDataGridView, repairsDataGridView);
        }

        private void updateDeliveryStatusButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) == false)
            {
                string deliveryStatus = deliveryComboBox.Text;

                DatabaseOperations.UpdateDeliveryStatus(deliveryComboBox, usernameTextBox, email, purchasesDataGridView);

                EmailOperations.DeliveryStatus(deliveryStatus, email, usernameTextBox, deliveryComboBox);

                DatabaseOperations.UpdateDeliveryView(usernameTextBox.Text, purchasesDataGridView);
            }
            else
            {
                MessageBox.Show("Please enter a username in to update the status");
            }
        }
    }
}
