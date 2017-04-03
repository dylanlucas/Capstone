using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class RefundStatusScreenForm : Form
    {
        public RefundStatusScreenForm()
        {
            InitializeComponent();
        }

        public string refundStatusScreenUsername { get; set; }

        private void moreInfoButton_Click(object sender, EventArgs e)
        {
            //Send information about the Refund status
            MessageBox.Show("Stage One = Order is currently being Processed and has not been received" +
                "\n" + "Stage Two = Order has been Received" +
                "\n" + "Stage Three = Refund is currently being processed" +
                "\n" + "Stage Four = Refund has been transacted" +
                "\n" + "Stage Five = Refund is complete");
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplicationForm mainApplicationForm = new MainApplicationForm();
            mainApplicationForm.mainApplicationUsername = refundStatusScreenUsername;           //Send the username information of the user to the main application
            mainApplicationForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void refundsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.refundsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void RefundStatusScreen_Load(object sender, EventArgs e)
        {
            //Call the ReguestRefundScreen for the DatabaseOperation's class
            DatabaseOperationsRefunds.RequestRefundScreen(refundStatusScreenUsername, refundsDataGridView);
        }

        private void refundsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.refundsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }
    }
}
