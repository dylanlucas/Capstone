﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GlobalSanicElectronics
{
    public partial class AccountCreationForm : Form
    {
        bool accountCreated;

        public AccountCreationForm()
        {
            InitializeComponent();   
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Call validation method for username to make sure field is correct
            if (Validation.UsernameValidation(usernameTextBox, errorProvider))
            {
                //Call validation method to make sure date of birth is correct
                if (Validation.BirthValidation(dOBTextBox, errorProvider))
                {
                    //Call validation method to make sure address is correct
                    if (Validation.AddressValidation(addressTextBox, errorProvider))
                    {
                        //Call validation method to make sure city is correct
                        if (Validation.CityValidation(cityTextBox, errorProvider))
                        {
                            //Call validation method to make sure state is correct
                            if (Validation.StateValidation(stateTextBox, errorProvider))
                            {
                                //Call validation method to make sure zip is correct
                                if (Validation.ZipValidation(zipTextBox, errorProvider))
                                {
                                    //Call validation method to make sure password is correct 
                                    if (Validation.PasswordValidation(passwordTextBox, errorProvider))
                                    {
                                        if (Validation.VerifyPassword(passwordTextBox, verifyPasswordTextBox, errorProvider))
                                        {
                                            //Call validation method to make sure email is correct
                                            if (Validation.EmailValidation(emailTextBox, errorProvider))
                                            {
                                                try
                                                {
                                                    //Create a Customer Information object and input all information to that object about the Customer
                                                    CustomerInformation newCustomer = new CustomerInformation();

                                                    newCustomer.Username = usernameTextBox.Text;
                                                    newCustomer.Password = PasswordOperations.AccountPasswordHashing(passwordTextBox.Text);
                                                    newCustomer.Email = emailTextBox.Text;
                                                    newCustomer.DOB = dOBTextBox.Text;
                                                    newCustomer.Address = addressTextBox.Text;
                                                    newCustomer.City = cityTextBox.Text;
                                                    newCustomer.State = stateTextBox.Text;
                                                    newCustomer.Zip = zipTextBox.Text;

                                                    //Call the DatabaseOperation to create the new user
                                                    if (accountCreated = DatabaseOperationsUser.CreateUser(newCustomer, usernameTextBox, emailTextBox, dOBTextBox, addressTextBox, cityTextBox, stateTextBox, zipTextBox) == true)
                                                    {
                                                        this.Hide();
                                                    }
                                                }
                                                catch (SqlException ex)
                                                {
                                                    MessageBox.Show(ex.Message);
                                                }
                                            }
                                        }                                        
                                    }
                                }
                            }
                        }
                    }
                }                
            }
            else
            {
                MessageBox.Show("Please make sure all fields are filled out correctly.");
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
            //Show error messages for the Password
            Validation.PasswordValidation(passwordTextBox, errorProvider);
        }

        private void emailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Show error messages for the Email
            Validation.EmailValidation(emailTextBox, errorProvider);
        }

        private void usernameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Show error messages for the Username
            Validation.UsernameValidation(usernameTextBox, errorProvider);
        }

        private void dOBTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Show error messages for the Date of Birth
            Validation.BirthValidation(dOBTextBox, errorProvider);
        }

        private void addressTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Show error messages for the Address
            Validation.AddressValidation(addressTextBox, errorProvider);
        }

        private void cityTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Show error messages for the City
            Validation.CityValidation(cityTextBox, errorProvider);
        }

        private void stateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Show error messages for the State
            Validation.StateValidation(stateTextBox, errorProvider);
        }

        private void zipTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Show error messages for the Zip
            Validation.ZipValidation(zipTextBox, errorProvider);
        }

        private void verifyPasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Show error message if passwords do not match
            Validation.VerifyPassword(passwordTextBox, verifyPasswordTextBox, errorProvider);
        }
    }
}