using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class RequestRefundScreenForm : Form
    {
        public RequestRefundScreenForm()
        {
            InitializeComponent();
        }

        public string refundRequestScreenUsername { get; set; }

        string email;

        private void requestRefundButton_Click(object sender, EventArgs e)
        {
            DatabaseOperationsRefunds.UserRequestRefunds(purchasesDataGridView, refundRequestScreenUsername);

            DatabaseOperationsRefunds.RequestRefundScreen(refundRequestScreenUsername, purchasesDataGridView);

            DatabaseOperationsRepairs.FillRepair(refundRequestScreenUsername, purchasesDataGridView);

            EmailOperations.RefundRequested(email, refundRequestScreenUsername);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplicationForm mainApplicationForm = new MainApplicationForm();
            mainApplicationForm.mainApplicationUsername = refundRequestScreenUsername;
            mainApplicationForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void purchasesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void RequestRefundScreen_Load(object sender, EventArgs e)
        {
            DatabaseOperationsRepairs.FillRepair(refundRequestScreenUsername, purchasesDataGridView);
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
    }
}
