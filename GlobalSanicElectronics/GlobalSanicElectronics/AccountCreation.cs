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
using System.Text.RegularExpressions;

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

            //Declare variable for Database
            System.Data.SqlClient.SqlConnection sqlConnectionLink =
                new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=I:\\Capstone\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True");

            bool checkPassword = validatePassword(passwordTextBox.Text.ToString());


            //Username checking
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a username");
            }
            else if (checkPassword == true)
            {
                try
                {
                    System.Data.SqlClient.SqlCommand createUserCommand = new System.Data.SqlClient.SqlCommand();
                    createUserCommand.CommandType = System.Data.CommandType.Text;
                    createUserCommand.CommandText = "INSERT into CustomerInformation (Username, Password, Email, DOB, Address, City, State, Zip) VALUES ('" + usernameTextBox.Text + "' , '" + passwordTextBox.Text + "' , '" + emailTextBox.Text + "' , '" + dOBTextBox.Text + "' , '" + addressTextBox.Text + "' , '" + cityTextBox.Text + "' , '" + stateTextBox.Text + "' , '" + zipTextBox.Text + "')";
                    createUserCommand.Connection = sqlConnectionLink;

                    sqlConnectionLink.Open();
                    createUserCommand.ExecuteNonQuery();
                    sqlConnectionLink.Close();

                    MessageBox.Show(usernameTextBox.Text + " has been created! Thank you for joining Global Sanic Electronics!");

                    //Hide this form so the user can no longer see it as it is no longer needed
                    this.Hide();

                    //Go to the MainApplication since the user has successfully logged in and created there account
                    MainApplication mainApplicationForm = new MainApplication();
                    mainApplicationForm.Show();

                }
                catch (SqlException)
                {
                    MessageBox.Show("Username already exists! Please use a different username");
                }
            }
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

        private bool validatePassword(string password)
        {
            var input = password;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password field cannot be empty or blank");
            }

            var containsNumber = new Regex(@"[0-9]+");
            var containsUpperCase = new Regex(@"[A-Z]+");
            var properLength = new Regex(@".{8,15}");
            var containsLowerCase = new Regex(@"[a-z]+");
            var containsSpecialChar = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!containsLowerCase.IsMatch(input))
            {
                MessageBox.Show("Password needs to have at least one lowercase letter");
                return false;
            }
            else if (!containsUpperCase.IsMatch(input))
            {
                MessageBox.Show("Password needs to have at least one upppercase letter");
                return false;
            }
            else if (!properLength.IsMatch(input))
            {
                MessageBox.Show("Password needs to be atleast 8 characters long");
                return false;
            }
            else if (!containsNumber.IsMatch(input))
            {
                MessageBox.Show("Password need to contain atleast one number");
                return false;
            }

            else if (!containsSpecialChar.IsMatch(input))
            {
                MessageBox.Show("Password should contain at least one specialChar");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

