using System;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            //Validating Account Creation fields
            Validation.UsernameValidation(usernameTextBox, errorProvider);
            Validation.BirthValidation(dOBTextBox, errorProvider);
            Validation.AddressValidation(addressTextBox, errorProvider);
            Validation.CityValidation(cityTextBox, errorProvider);
            Validation.StateValidation(stateTextBox, errorProvider);
            Validation.ZipValidation(zipTextBox, errorProvider);

            if (Validation.PasswordValidation(passwordTextBox, errorProvider))
            {
                if (Validation.EmailValidation(emailTextBox, errorProvider))
                {
                    try
                    {                        
                        CustomerInformation newCustomer = new CustomerInformation();

                        newCustomer.Username = usernameTextBox.Text;
                        newCustomer.Password = PasswordOperations.AccountPasswordHashing(passwordTextBox.Text);
                        newCustomer.Email = emailTextBox.Text;
                        newCustomer.DOB = dOBTextBox.Text;
                        newCustomer.Address = addressTextBox.Text;
                        newCustomer.City = cityTextBox.Text;
                        newCustomer.State = stateTextBox.Text;
                        newCustomer.Zip = zipTextBox.Text;

                        DatabaseOperations.CreateUser(newCustomer);

                        MessageBox.Show(usernameTextBox.Text + " has been created! Thank you for joining Global Sanic Electronics! An email has been sent to you to confirm your account registration!");

                        EmailOperations.UserCreatedEmail(emailTextBox.Text, usernameTextBox.Text, dOBTextBox.Text, addressTextBox.Text, cityTextBox.Text, stateTextBox.Text, zipTextBox.Text);

                        //Hide this form so the user can no longer see it as it is no longer needed
                        this.Hide();

                        //Go to the MainApplication since the user has successfully logged in and created there account
                        MainApplication mainApplicationForm = new MainApplication();
                        string username = usernameTextBox.Text;
                        mainApplicationForm.mainApplicationUsername = username;
                        mainApplicationForm.Show();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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

        private void AccountCreation_Load(object sender, EventArgs e)
        {
            try
            {

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }      

        private void passwordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validation.PasswordValidation(passwordTextBox, errorProvider);
        }

        private void emailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validation.EmailValidation(emailTextBox, errorProvider);
        }

        private void usernameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validation.UsernameValidation(usernameTextBox, errorProvider);
        }

        private void dOBTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validation.BirthValidation(dOBTextBox, errorProvider);
        }

        private void addressTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validation.AddressValidation(addressTextBox, errorProvider);
        }

        private void cityTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validation.CityValidation(cityTextBox, errorProvider);
        }

        private void stateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validation.StateValidation(stateTextBox, errorProvider);
        }

        private void zipTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validation.ZipValidation(zipTextBox, errorProvider);
        }
    }
}