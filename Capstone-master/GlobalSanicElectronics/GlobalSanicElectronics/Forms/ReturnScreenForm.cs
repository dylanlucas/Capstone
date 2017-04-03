using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class ReturnScreenForm : Form
    {
        public ReturnScreenForm()
        {
            InitializeComponent();
        }

        public string refundScreenFormUsername { get; set; }

        private void requestRefundButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            bool verifyRefundTable;
                    
            //Make sure user has a refund table
            if (verifyRefundTable = DatabaseOperationsRepairs.RequestRepairs(refundScreenFormUsername))
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();

                //Go to the RequestRefundScreen so the user can request refund on an item, IF the user has purchased an item from this company, if not will not allow them to proceed
                RequestRefundScreenForm requestRefundScreenForm = new RequestRefundScreenForm();
                requestRefundScreenForm.refundRequestScreenUsername = refundScreenFormUsername;         //Send the username of the user to the refundscreenform
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
            RefundStatusScreenForm refundStatusScreenForm = new RefundStatusScreenForm();
            refundStatusScreenForm.refundStatusScreenUsername = refundScreenFormUsername;           //Send the username of the user to the refundscreenform
            refundStatusScreenForm.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplicationForm mainApplicationForm = new MainApplicationForm();
            mainApplicationForm.mainApplicationUsername = refundScreenFormUsername;             //Send the username of the user to the refundscreenform
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
