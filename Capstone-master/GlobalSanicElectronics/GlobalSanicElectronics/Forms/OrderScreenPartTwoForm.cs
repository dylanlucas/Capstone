using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace GlobalSanicElectronics
{
    public partial class OrderScreenPartTwoForm : Form
    {
        public OrderScreenPartTwoForm()
        {
            InitializeComponent();      
        }

        public double userPrice { get; set; }
        public string userName { get; set; }
        public string console { get; set; }
        public string computer { get; set; }
        public string tablet { get; set; }
        public string television { get; set; }   

        private void OrderScreenPartTwocs_Load(object sender, EventArgs e)
        {
            //Get payment information for the user and make sure is correct
            GeneralOperations.DefaultInformation(shippingTwoRadioButton, totalPaymentDisplayLabel, yearComboBox, userPrice);

            //Get the Shipping information of the User when they created there account
            DatabaseOperationsPurchases.ShippingInformation(userName, addressTextBox, cityTextBox, stateTextBox, zipTextBox);            
        }

        private void confirmShippingInformationButton_Click(object sender, EventArgs e)
        {
            //Call Validation to make sure the Address is correct
            if (Validation.AddressValidation(addressTextBox, errorProvider))
            {
                //Call Validation to make sure the City is correct
                if (Validation.CityValidation(cityTextBox, errorProvider))
                {
                    //Call Validation to make sure State is correct
                    if (Validation.StateValidation(stateTextBox, errorProvider))
                    {
                        //Call Validation to make sure Zip is correct
                        if (Validation.ZipValidation(zipTextBox, errorProvider))
                        {
                            //Make sure the user has selected shipping information
                            GeneralOperations.ConfirmShipping(shippingGroupBox);
                        }
                    }
                }
            }
        }

        private void confirmPaymentButton_Click(object sender, EventArgs e)
        {
            //Call Validation to make sure the Username is correct
            if (GeneralOperations.ConfirmName(nameTextBox, errorProvider))
            {
                //Call Validation to make sure the Username is correct
                if (GeneralOperations.ConfirmName(nameTextBox, errorProvider))
                {
                    //Call Validation to make sure Card Number is correct
                    if (GeneralOperations.ConfirmNumber(cardNumberTextBox, errorProvider))
                    {
                        //Make sure Card number is 19 characters only
                        if (cardNumberTextBox.Text.Length == 19)
                        {
                            //Call Validation for the Expiration Date to make sure it is in correct format
                            if (GeneralOperations.ConfirmExpirationDate(monthCombBox, yearComboBox, errorProvider))
                            {
                                //Hash & Salt Credit Card information so nobody can see it
                                DatabaseOperationsPurchases.HashCreditCard(cardNumberTextBox, nameTextBox, userName, paymentGroupBox);
                            }
                        }  
                        else
                        {
                            //Send error message that the card number is incorrect
                            errorProvider.SetError(cardNumberTextBox, "Invalid card number.");
                        }                      
                    }
                }
            }           
        }

        private void cardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Making sure only numbers can be entered
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void expirationDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Making sure only numbers can be entered
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
            
        }

        private void cardNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string value = cardNumberTextBox.Text;      //Hold information of the card number

            //Make sure that the card number is not null
            if (!string.IsNullOrEmpty(value) && e.KeyCode != Keys.Back)
            {
                //Way to add - after every 4 characters
                value = value.Replace("-", "");
                string divide = Regex.Replace(value, @"\d\d\d\d(?!$)", "$0-");      //Regex to Add a - after every 4 characters in the number
                cardNumberTextBox.Text = divide;
                cardNumberTextBox.SelectionStart = cardNumberTextBox.Text.Length;
            }
        }

        private void confirmShippingSpeedButton_Click(object sender, EventArgs e)
        {
            //Validation to make sure Shipping information is all correct
            GeneralOperations.ConfirmShippingSpeed(shippingOneRadioButton, userPrice, shippingSpeedGroupBox, totalPaymentDisplayLabel);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            OrderScreenForm orderScreenForm = new OrderScreenForm();
            orderScreenForm.orderFormUsername = userName;       //Send the username of the user to the order screen
            orderScreenForm.overallPrice = userPrice;           //Send the price of the user to the order screen
            orderScreenForm.Show();
        }

        private void confirmPurchaseButton_Click(object sender, EventArgs e)
        {
            if (shippingGroupBox.Enabled == false && shippingSpeedGroupBox.Enabled == false && paymentGroupBox.Enabled == false)
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();

                //Go to the Receipt Form since the user has requested to
                ReceiptScreenForm receiptScreenForm = new ReceiptScreenForm();
                receiptScreenForm.username = userName;
                receiptScreenForm.price = userPrice;
                receiptScreenForm.console = console;
                receiptScreenForm.computer = computer;
                receiptScreenForm.tablet = tablet;
                receiptScreenForm.television = television;
                receiptScreenForm.Show();
            }
            else
            {
                MessageBox.Show("Please ensure all fields have been confirmed");
            }
        }

        private void addressTextBox_Validating(object sender, CancelEventArgs e)
        {
            //To show error message for Address
            Validation.AddressValidation(addressTextBox, errorProvider);
        }

        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            //To show error message for City
            Validation.CityValidation(cityTextBox, errorProvider);
        }

        private void stateTextBox_Validating(object sender, CancelEventArgs e)
        {
            //To show error message for State
            Validation.StateValidation(stateTextBox, errorProvider);
        }

        private void zipTextBox_Validating(object sender, CancelEventArgs e)
        {
            //To show error message for Zip
            Validation.ZipValidation(zipTextBox, errorProvider);
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            //To show error message for Name
            GeneralOperations.ConfirmName(nameTextBox, errorProvider);
        }

        private void cardNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            //To show error message for Card Number
            GeneralOperations.ConfirmNumber(cardNumberTextBox, errorProvider);
        }

        private void monthCombBox_Validating(object sender, CancelEventArgs e)
        {
            //To show error message for Expiration Date for month
            GeneralOperations.ConfirmExpirationDate(monthCombBox, yearComboBox, errorProvider);
        }

        private void yearComboBox_Validating(object sender, CancelEventArgs e)
        {
            //To show error message for Expiration Date for year
            GeneralOperations.ConfirmExpirationDate(monthCombBox, yearComboBox, errorProvider);
        }
    }
}
