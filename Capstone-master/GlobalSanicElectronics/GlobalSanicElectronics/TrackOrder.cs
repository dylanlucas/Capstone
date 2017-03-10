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
    public partial class TrackOrder : Form
    {       

        public TrackOrder()
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
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.Purchases' table. You can move, or remove it, as needed.
            this.purchasesTableAdapter.Fill(this.gSEDatabaseDataSet.Purchases);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.Purchases' table. You can move, or remove it, as needed.
            this.purchasesTableAdapter.Fill(this.gSEDatabaseDataSet.Purchases);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.Purchases' table. You can move, or remove it, as needed.
            this.purchasesTableAdapter.Fill(this.gSEDatabaseDataSet.Purchases);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.Purchases' table. You can move, or remove it, as needed.
            this.purchasesTableAdapter.Fill(this.gSEDatabaseDataSet.Purchases);

            var select = "SELECT * FROM Purchases WHERE CustomerName= '" + orderUsername + "'";
            var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            purchasesDataGridView.ReadOnly = true;
            purchasesDataGridView.DataSource = ds.Tables[0];

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
            MainApplication mainApplicationForm = new MainApplication();
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
                "\n" + "Stage Six = Order has been delivered");
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
