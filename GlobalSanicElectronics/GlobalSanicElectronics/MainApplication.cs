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

namespace GlobalSanicElectronics
{
    public partial class MainApplication : Form
    {
        public MainApplication()
        {
            InitializeComponent();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {

        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the Cart Screen as user requested
            Cart cartForm = new Cart();
            cartForm.Show();
        }

        private void repairsButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the RepairScreenForm as the user has requested it to allow the user with some options available in that category
            RepairScreen repairScreenForm = new RepairScreen();
            repairScreenForm.Show();
        }

        private void returnsButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the ReturnScreen as the user has requested it to allow the user with some options available in that category
            ReturnScreen returnScreenForm = new ReturnScreen();
            returnScreenForm.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //As user has opted to log out, take them back to Launch Screen giving them the option to resign in or close out of the application completely from there
            LaunchScreen launchScreenForm = new LaunchScreen();
            launchScreenForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application out when the user clicks Exit
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Allow the user to get contact information about the company incase needed and as they clicked the button they have requested to go here
            ContactScreen contactScreenForm = new ContactScreen();
            contactScreenForm.Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Allow the user go to the order screen, IF the cart is equal to or greater than 1
            OrderScreen orderScreenForm = new OrderScreen();
            orderScreenForm.Show();
        }

        private void televisionButton_Click(object sender, EventArgs e)
        {
            //Set this directory to be visible
            televisionDirectoryDataGridView.Visible = true;

            //All other directors to be invisible
            consoleDirectoryDataGridView.Visible = false;
            tabletDirectorDataGridView.Visible = false;
            computerDirectoryDataGridView.Visible = false;
        }

        private void consoleButton_Click(object sender, EventArgs e)
        {
            //Set this directory to be visible
            consoleDirectoryDataGridView.Visible = true;

            //All other directors to be invisible
            televisionDirectoryDataGridView.Visible = false;
            tabletDirectorDataGridView.Visible = false;
            computerDirectoryDataGridView.Visible = false;
        }

        private void tabletButton_Click(object sender, EventArgs e)
        {
            //Set this directory to be visible
            tabletDirectorDataGridView.Visible = true;

            //All other directors to be invisible
            televisionDirectoryDataGridView.Visible = false;
            consoleDirectoryDataGridView.Visible = false;
            computerDirectoryDataGridView.Visible = false;
        }

        private void computerButton_Click(object sender, EventArgs e)
        {
            //Set this directory to be visible
            computerDirectoryDataGridView.Visible = true;

            //All other directors to be invisible
            televisionDirectoryDataGridView.Visible = false;
            consoleDirectoryDataGridView.Visible = false;
            tabletDirectorDataGridView.Visible = false;
        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void televisionDirectoryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.televisionDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void MainApplication_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.ComputerDirectory' table. You can move, or remove it, as needed.
            this.computerDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.ComputerDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TabletDirector' table. You can move, or remove it, as needed.
            this.tabletDirectorTableAdapter.Fill(this.gSEDatabaseDataSet.TabletDirector);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.ConsoleDirectory' table. You can move, or remove it, as needed.
            this.consoleDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.ConsoleDirectory);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.TelevisionDirectory' table. You can move, or remove it, as needed.
            this.televisionDirectoryTableAdapter.Fill(this.gSEDatabaseDataSet.TelevisionDirectory);

        }
    }
}
