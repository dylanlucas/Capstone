using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class RepairScreenForm : Form
    {
        public RepairScreenForm()
        {
            InitializeComponent();
        }

        public string repairScreenFormUsername { get; set; }

        private void requestRepairButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            bool verifyRepairTable;

            if (verifyRepairTable = DatabaseOperationsRepairs.RequestRepairs(repairScreenFormUsername))
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();

                //Go to the RequestRepairScreen so the user can request repair on an item, IF the user has purchased an item from this company, if not will not allow them to proceed
                RequestRepairScreenForm requestRepairScreenForm = new RequestRepairScreenForm();
                requestRepairScreenForm.requestRepaireFormUsername = repairScreenFormUsername;          //Send the username of the user to the repairScreen
                requestRepairScreenForm.Show();
            }
            else
            {
                //Send a message box to say that there are no items elgible for repair
                MessageBox.Show("No items currently elgible for repair!");
            }
        }

        private void repairStatusButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the RepairStatusScreen so the user can check the status of their repair IF they have a repair currently in progress
            RepairStatusScreenForm repairStatusScreenForm = new RepairStatusScreenForm();
            repairStatusScreenForm.repairStatusScreenUsername = repairScreenFormUsername;           //Send the username of the user to the RepairScreen
            repairStatusScreenForm.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplicationForm mainApplicationForm = new MainApplicationForm();
            mainApplicationForm.mainApplicationUsername = repairScreenFormUsername;             //Send the username of the user to the RepairScreen
            mainApplicationForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void RepairScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
