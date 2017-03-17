using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace GlobalSanicElectronics
{
    public partial class TrackOrderForm : Form
    {       

        public TrackOrderForm()
        {
            InitializeComponent();
        }

        public string orderUsername { get; set; }

        private void purchasesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void TrackOrder_Load(object sender, EventArgs e)
        {
            DatabaseOperationsPurchases.TrackUserOrder(orderUsername, purchasesDataGridView);

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplicationForm mainApplicationForm = new MainApplicationForm();
            mainApplicationForm.mainApplicationUsername = orderUsername;
            mainApplicationForm.Show();
        }

        private void moreInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stage One = Order is currently being Processed and has not shipped" +
                "\n" + "Stage Two = Order is being packed up to Ship" +
                "\n" + "Stage Three = Order has been Shipped" +
                "\n" + "Stage Four = Order has been delivered to local mailing facility" +
                "\n" + "Stage Five = Order is out for delivery" +
                "\n" + "Stage Six = Order has been delivered" + "\n\n" +
                "If your status is in Repair or Refund, please check the Repair or Refund status screen");
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
    }
}
