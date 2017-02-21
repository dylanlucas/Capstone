using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class AccountCreation : Form
    {
        public AccountCreation()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Once the user has successfully created there account take them to the main application
            //this.customerInformationTableAdapter.Insert(usernameTextBox.Text, passwordTextBox.Text, emailTextBox.Text, dOBTextBox.Text, addressTextBox.Text, cityTextBox.Text, stateTextBox.Text, zipTextBox.Text);

            System.Data.SqlClient.SqlConnection sqlConnectionLink =
                new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=I:\\Capstone\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT into CustomerInformation (Username, Password, Email, DOB, Address, City, State, Zip) VALUES ('" + usernameTextBox.Text + "' , '" + passwordTextBox.Text + "' , '" + emailTextBox.Text + "' , '" + dOBTextBox.Text + "' , '" + addressTextBox.Text + "' , '" + cityTextBox.Text + "' , '" + stateTextBox.Text + "' , '" + zipTextBox.Text + "')";
            cmd.Connection = sqlConnectionLink;

            sqlConnectionLink.Open();
            cmd.ExecuteNonQuery();
            sqlConnectionLink.Close();

            MessageBox.Show(usernameTextBox.Text + " has been created! Thank you for joining Global Sanic Electronics!");
            //Hide this form so the user can no longer see it as it is no longer needed
            //this.Hide();

            //Go to the MainApplication since the user has successfully logged in and created there account
            //MainApplication mainApplicationForm = new MainApplication();
            //mainApplicationForm.Show();
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

        private void customerInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void customerInformationBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void customerInformationBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void customerInformationBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void customerInformationBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void customerInformationBindingNavigatorSaveItem_Click_5(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void customerInformationBindingNavigatorSaveItem_Click_6(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void customerInformationBindingNavigatorSaveItem_Click_7(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void customerInformationBindingNavigatorSaveItem_Click_8(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void AccountCreation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.CustomerInformation' table. You can move, or remove it, as needed.
            this.customerInformationTableAdapter.Fill(this.gSEDatabaseDataSet.CustomerInformation);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.CustomerInformation' table. You can move, or remove it, as needed.
            this.customerInformationTableAdapter.Fill(this.gSEDatabaseDataSet.CustomerInformation);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.CustomerInformation' table. You can move, or remove it, as needed.
            this.customerInformationTableAdapter.Fill(this.gSEDatabaseDataSet.CustomerInformation);
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.CustomerInformation' table. You can move, or remove it, as needed.
            this.customerInformationTableAdapter.Fill(this.gSEDatabaseDataSet.CustomerInformation);

            //Clear text fields of all information so user doesn't get information in first fields in CustomerInformation table in the GSEDatabase
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            emailTextBox.Text = "";
            dOBTextBox.Text = "";
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            stateTextBox.Text = "";
            zipTextBox.Text = "";
        }

        private void customerInformationBindingNavigatorSaveItem_Click_9(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void customerInformationBindingNavigatorSaveItem_Click_10(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void customerInformationBindingNavigatorSaveItem_Click_11(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }
    }
}
