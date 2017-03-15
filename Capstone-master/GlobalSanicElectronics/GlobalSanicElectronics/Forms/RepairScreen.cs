using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class RepairScreen : Form
    {
        public RepairScreen()
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
                RequestRepairScreen requestRepairScreenForm = new RequestRepairScreen();
                requestRepairScreenForm.requestRepaireFormUsername = repairScreenFormUsername;
                requestRepairScreenForm.Show();
            }
            else
            {
                MessageBox.Show("No items currently elgible for repair!");
            }
        }

        private void repairStatusButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the RepairStatusScreen so the user can check the status of their repair IF they have a repair currently in progress
            RepairStatusScreen repairStatusScreenForm = new RepairStatusScreen();
            repairStatusScreenForm.repairStatusScreenUsername = repairScreenFormUsername;
            repairStatusScreenForm.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.mainApplicationUsername = repairScreenFormUsername;
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
