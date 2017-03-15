using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class RepairStatusScreen : Form
    {
        public RepairStatusScreen()
        {
            InitializeComponent();
        }

        public string repairStatusScreenUsername { get; set; }

        private void moreInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stage One = Order is currently being Processed and has not been received" +
                "\n" + "Stage Two = Order has been Received" +
                "\n" + "Stage Three = Problem is currently being investigated" +
                "\n" + "Stage Four = Problem has been found and is being repaired" +
                "\n" + "Stage Five = Order has been successfully repaired and is being shipped back" +
                "\n" + "Stage Six = Order has been shipped and delivered");
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.mainApplicationUsername = repairStatusScreenUsername;
            mainApplicationForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void repairsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.repairsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void RepairStatusScreen_Load(object sender, EventArgs e)
        {
            DatabaseOperations.RequestRepairScreen(repairStatusScreenUsername, repairsDataGridView);
        }
    }
}
