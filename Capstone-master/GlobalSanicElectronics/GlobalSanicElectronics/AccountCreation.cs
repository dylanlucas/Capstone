﻿using System;
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
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Configuration;

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
            
            bool checkPassword = validatePassword(passwordTextBox.Text.ToString());
            bool checkEmail = validateEmail(emailTextBox.Text.ToString());

            //Username checking
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a username");
                usernameTextBox.BackColor = Color.Red;
                usernameTextBox.ForeColor = Color.White;
            }
            else
            {
                usernameTextBox.BackColor = Color.White;
                usernameTextBox.ForeColor = Color.Black;
            }

            if (dOBTextBox.Text == "")
            {
                MessageBox.Show("Please enter a Birthdate");
                dOBTextBox.BackColor = Color.Red;
                dOBTextBox.ForeColor = Color.White;
            }
            else
            {
                dOBTextBox.BackColor = Color.White;
                dOBTextBox.ForeColor = Color.Black;
            }

            if (addressTextBox.Text == "")
            {
                MessageBox.Show("Please enter an address");
                addressTextBox.BackColor = Color.Red;
                addressTextBox.ForeColor = Color.White;
            }
            else
            {
                addressTextBox.BackColor = Color.White;
                addressTextBox.ForeColor = Color.Black;
            }

            if (cityTextBox.Text == "")
            {
                MessageBox.Show("Please enter a city");
                cityTextBox.BackColor = Color.Red;
                cityTextBox.ForeColor = Color.White;
            }
            else
            {
                cityTextBox.BackColor = Color.White;
                cityTextBox.ForeColor = Color.Black;
            }

            if (stateTextBox.Text == "")
            {
                MessageBox.Show("Please enter a state");
                stateTextBox.BackColor = Color.Red;
                stateTextBox.ForeColor = Color.White;
            }
            else
            {
                stateTextBox.BackColor = Color.White;
                stateTextBox.ForeColor = Color.Black;
            }

            if (zipTextBox.Text == "")
            {
                MessageBox.Show("Please enter a zip");
                zipTextBox.BackColor = Color.Red;
                zipTextBox.ForeColor = Color.White;
            }
            else
            {
                zipTextBox.BackColor = Color.White;
                zipTextBox.ForeColor = Color.Black;
            }

            if (checkPassword == true)
            {
                if (checkEmail == true)
                {
                    try
                    {
                        string salt = "WquZ012C";

                        var bytes = new UTF8Encoding().GetBytes(salt + passwordTextBox.Text);
                        byte[] hashBytes;
                        using (var algorithm = new System.Security.Cryptography.SHA512Managed())
                        {
                            hashBytes = algorithm.ComputeHash(bytes);
                        }

                        string passHash = Convert.ToBase64String(hashBytes);


                        System.Data.SqlClient.SqlCommand createUserCommand = new System.Data.SqlClient.SqlCommand();
                        createUserCommand.CommandType = System.Data.CommandType.Text;
                        createUserCommand.CommandText = "INSERT into CustomerInformation (Username, Password, Email, DOB, Address, City, State, Zip) VALUES ('" + usernameTextBox.Text + "' , '" + passHash + "' , '" + emailTextBox.Text + "' , '" + dOBTextBox.Text + "' , '" + addressTextBox.Text + "' , '" + cityTextBox.Text + "' , '" + stateTextBox.Text + "' , '" + zipTextBox.Text + "')";
                        createUserCommand.Connection = DatabaseOperations.sqlConnectionLink;

                        DatabaseOperations.sqlConnectionLink.Open();
                        createUserCommand.ExecuteNonQuery();
                        DatabaseOperations.sqlConnectionLink.Close();

                        MessageBox.Show(usernameTextBox.Text + " has been created! Thank you for joining Global Sanic Electronics! An email has been sent to you to confirm your account registration!");

                        //Way to send user an email with all account information and confirm that there account is created.
                        var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                        var toAddress = new MailAddress(emailTextBox.Text, usernameTextBox.Text);
                        const string fromPassword = "GSEPassword";
                        const string subject = "Thank you for joining Global Sanic Electronics!";
                        string body = "Hello " + usernameTextBox.Text + " thank you for joining Global Sanic Electronics." + "\n\n" +
                            "To ensure all your information is correct, this is what you entered upon account creation. If any of this information needs to be updated, please do not hesitate to email us back" + "\n\n" +
                            "Email = " + emailTextBox.Text + "\n" +
                            "Date of Birth = " + dOBTextBox.Text + "\n" +
                            "Street Address = " + addressTextBox.Text + "\n" +
                            "City = " + cityTextBox.Text + "\n" +
                            "State = " + stateTextBox.Text + "\n" +
                            "Zip = " + zipTextBox.Text + "\n\n" +
                            "Thank you once again for joining Global Sanic Electronics! We hope you enjoy your stay!";

                        //Area to establish a connection with the smtpclient and put the host and port number down
                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                        };

                        //Area to actually send the message out to the user
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                        {
                            smtp.Send(message);
                        }

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

        /**
         * The block of code is used to make sure that the user is inputting 
         * a good and strong password
         */
        private bool validatePassword(string password)
        {
            var input = password;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Password field cannot be empty or blank");
                passwordTextBox.BackColor = Color.Red;
                passwordTextBox.ForeColor = Color.White;
            }

            var containsNumber = new Regex(@"[0-9]+");
            var containsUpperCase = new Regex(@"[A-Z]+");
            var properLength = new Regex(@".{8,15}");
            var containsLowerCase = new Regex(@"[a-z]+");
            var containsSpecialChar = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!containsLowerCase.IsMatch(input))
            {
                MessageBox.Show("Password needs to have at least one lowercase letter");
                passwordTextBox.BackColor = Color.Red;
                passwordTextBox.ForeColor = Color.White;
                return false;
            }
            else if (!containsUpperCase.IsMatch(input))
            {
                MessageBox.Show("Password needs to have at least one upppercase letter");
                passwordTextBox.BackColor = Color.Red;
                passwordTextBox.ForeColor = Color.White;
                return false;
            }
            else if (!properLength.IsMatch(input))
            {
                MessageBox.Show("Password needs to be atleast 8 characters long");
                passwordTextBox.BackColor = Color.Red;
                passwordTextBox.ForeColor = Color.White;
                return false;
            }
            else if (!containsNumber.IsMatch(input))
            {
                MessageBox.Show("Password need to contain atleast one number");
                passwordTextBox.BackColor = Color.Red;
                passwordTextBox.ForeColor = Color.White;
                return false;
            }

            else if (!containsSpecialChar.IsMatch(input))
            {
                MessageBox.Show("Password should contain at least one specialChar");
                passwordTextBox.BackColor = Color.Red;
                passwordTextBox.ForeColor = Color.White;
                return false;
            }
            else
            {
                passwordTextBox.BackColor = Color.White;
                passwordTextBox.ForeColor = Color.Black;

                return true;
            }
        }

        /**
         * This code is to check and make sure that the user is inputting a email that is
         * in the correct format IE sample@stuff.com
         */        
        private bool validateEmail(string email)
        {
            var input = email;      //Gets the string when the method is called and assigns it to input

            var validEmail = new Regex(@"[a-zA-Z0-9]{3,20}@[a-zA-Z0-9]{3,20}.[a-zA-Z0-9]{3}"); 
            
            if (!validEmail.IsMatch(input))
            {
                //MessageBox.Show("Ensure that yoor email is in the correct format \n correctformat@this.com");

                MessageBox.Show(this, "Correct format \n \n correctformat@this.com.", 
                                   "Wrong Email Format", MessageBoxButtons.OK, 
                                   MessageBoxIcon.Information, 
                                   MessageBoxDefaultButton.Button1);

                emailTextBox.BackColor = Color.Red;
                emailTextBox.ForeColor = Color.White;

                return false;
            }
            else
            {
                emailTextBox.BackColor = Color.White;
                emailTextBox.ForeColor = Color.Black;

                return true;
            }
        }

        //Method to allow the user to push enter instead of actually Confirm.
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = confirmButton;
        }

        //Method to allow the user to push enter instead of actually Confirm.
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = confirmButton;
        }

        //Method to allow the user to push enter instead of actually Confirm.
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = confirmButton;
        }

        //Method to allow the user to push enter instead of actually Confirm.
        private void dOBTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = confirmButton;
        }

        //Method to allow the user to push enter instead of actually Confirm.
        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = confirmButton;
        }

        //Method to allow the user to push enter instead of actually Confirm.
        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = confirmButton;
        }

        //Method to allow the user to push enter instead of actually Confirm.
        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = confirmButton;
        }

        //Method to allow the user to push enter instead of actually Confirm.
        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = confirmButton;
        }
    }
}

