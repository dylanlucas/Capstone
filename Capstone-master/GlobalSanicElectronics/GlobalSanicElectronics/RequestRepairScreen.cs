using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class RequestRepairScreen : Form
    {
        public RequestRepairScreen()
        {
            InitializeComponent();
        }

        public string requestRepaireFormUsername { get; set; }

        string email;

        private void requestRepairButton_Click(object sender, EventArgs e)
        {
            DatabaseOperations.UserRequestRepairs(purchasesDataGridView, requestRepaireFormUsername);

            DatabaseOperations.RequestRepairScreen(requestRepaireFormUsername, purchasesDataGridView);

            DatabaseOperations.FillRepair(requestRepaireFormUsername, purchasesDataGridView);

            EmailOperations.RepairRequested(email, requestRepaireFormUsername);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.mainApplicationUsername = requestRepaireFormUsername;
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

        private void RequestRepairScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.Repairs' table. You can move, or remove it, as needed.
            this.repairsTableAdapter.Fill(this.gSEDatabaseDataSet.Repairs);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.Repairs' table. You can move, or remove it, as needed.
            this.repairsTableAdapter.Fill(this.gSEDatabaseDataSet.Repairs);

            DatabaseOperations.FillRepair(requestRepaireFormUsername, purchasesDataGridView);

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
