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
    public partial class RequestRepairScreenForm : Form
    {
        public RequestRepairScreenForm()
        {
            InitializeComponent();
        }

        public string requestRepaireFormUsername { get; set; }          //Get the username of the user

        string email;                                                   //Get the email of the user

        private void requestRepairButton_Click(object sender, EventArgs e)
        {
            //Call the user requested repair operation
            DatabaseOperationsRepairs.UserRequestRepairs(purchasesDataGridView, requestRepaireFormUsername);

            //Get the repair screen information
            DatabaseOperationsRepairs.RequestRepairScreen(requestRepaireFormUsername, purchasesDataGridView);

            //Fill the repair screen information
            DatabaseOperationsRepairs.FillRepair(requestRepaireFormUsername, purchasesDataGridView);

            //Send an email to the user that they have requested a repair
            EmailOperations.RepairRequested(email, requestRepaireFormUsername);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplicationForm mainApplicationForm = new MainApplicationForm();
            mainApplicationForm.mainApplicationUsername = requestRepaireFormUsername;       //Send the username of the user to the main application
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
            DatabaseOperationsRepairs.FillRepair(requestRepaireFormUsername, purchasesDataGridView);
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

        private void purchasesBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }
    }
}
