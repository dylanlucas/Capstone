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
    public partial class RefundStatusScreen : Form
    {
        public RefundStatusScreen()
        {
            InitializeComponent();
        }

        public string refundStatusScreenUsername { get; set; }

        private void moreInfoButton_Click(object sender, EventArgs e)
        {
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
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.mainApplicationUsername = refundStatusScreenUsername;
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
            var select = "SELECT * From Refunds WHERE Username= '" + refundStatusScreenUsername + "'";
            var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            refundsDataGridView.DataSource = ds.Tables[0];
        }

        private void refundsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.refundsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }
    }
}
