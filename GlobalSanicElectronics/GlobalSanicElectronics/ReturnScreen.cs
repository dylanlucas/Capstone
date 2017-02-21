using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class ReturnScreen : Form
    {
        public ReturnScreen()
        {
            InitializeComponent();
        }

        private void requestRefundButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the RequestRefundScreen so the user can request refund on an item, IF the user has purchased an item from this company, if not will not allow them to proceed
            RequestRefundScreen requestRefundScreenForm = new RequestRefundScreen();
            requestRefundScreenForm.Show();
        }

        private void refundStatusButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the RefundStatusScreen so the user can check the status of their refund IF they have a refund currently in progress
            RefundStatusScreen refundStatusScreenForm = new RefundStatusScreen();
            refundStatusScreenForm.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }
    }
}
