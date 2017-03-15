using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class ReturnScreen : Form
    {
        public ReturnScreen()
        {
            InitializeComponent();
        }

        public string refundScreenFormUsername { get; set; }

        private void requestRefundButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            bool verifyRefundTable;
                    
            if (verifyRefundTable = DatabaseOperations.RequestRepairs(refundScreenFormUsername))
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();

                //Go to the RequestRefundScreen so the user can request refund on an item, IF the user has purchased an item from this company, if not will not allow them to proceed
                RequestRefundScreen requestRefundScreenForm = new RequestRefundScreen();
                requestRefundScreenForm.refundRequestScreenUsername = refundScreenFormUsername;
                requestRefundScreenForm.Show();
            }
            else
            {
                MessageBox.Show("No items currently elgible for refund!");
            }
        }

        private void refundStatusButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the RefundStatusScreen so the user can check the status of their refund IF they have a refund currently in progress
            RefundStatusScreen refundStatusScreenForm = new RefundStatusScreen();
            refundStatusScreenForm.refundStatusScreenUsername = refundScreenFormUsername;
            refundStatusScreenForm.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.mainApplicationUsername = refundScreenFormUsername;
            mainApplicationForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void ReturnScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
