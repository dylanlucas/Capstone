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
            GeneralOperations.DefaultInformation(shippingTwoRadioButton, totalPaymentDisplayLabel, yearComboBox, userPrice);

            DatabaseOperationsPurchases.ShippingInformation(userName, addressTextBox, cityTextBox, stateTextBox, zipTextBox);            
        }

        private void confirmShippingInformationButton_Click(object sender, EventArgs e)
        {
            if (Validation.AddressValidation(addressTextBox, errorProvider))
            {
                if (Validation.CityValidation(cityTextBox, errorProvider))
                {
                    if (Validation.StateValidation(stateTextBox, errorProvider))
                    {
                        if (Validation.ZipValidation(zipTextBox, errorProvider))
                        {
                            GeneralOperations.ConfirmShipping(shippingGroupBox);
                        }
                    }
                }
            }
        }

        private void confirmPaymentButton_Click(object sender, EventArgs e)
        {
            if (GeneralOperations.ConfirmName(nameTextBox, errorProvider))
            {
                if (GeneralOperations.ConfirmName(nameTextBox, errorProvider))
                {
                    if (GeneralOperations.ConfirmNumber(cardNumberTextBox, errorProvider))
                    {
                        if (GeneralOperations.ConfirmExpirationDate(monthCombBox, yearComboBox, errorProvider))
                        {
                            DatabaseOperationsPurchases.HashCreditCard(cardNumberTextBox, nameTextBox, userName, paymentGroupBox);
                        }
                    }
                }
            }           
        }

        private void cardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void expirationDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
            
        }

        private void cardNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string value = cardNumberTextBox.Text;

            if (!string.IsNullOrEmpty(value) && e.KeyCode != Keys.Back)
            {
                value = value.Replace("-", "");
                string divide = Regex.Replace(value, @"\d\d\d\d(?!$)", "$0-");
                cardNumberTextBox.Text = divide;
                cardNumberTextBox.SelectionStart = cardNumberTextBox.Text.Length;
            }
        }

        private void confirmShippingSpeedButton_Click(object sender, EventArgs e)
        {
            GeneralOperations.ConfirmShippingSpeed(shippingOneRadioButton, userPrice, shippingSpeedGroupBox, totalPaymentDisplayLabel);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            OrderScreenForm orderScreenForm = new OrderScreenForm();
            orderScreenForm.orderFormUsername = userName;
            orderScreenForm.overallPrice = userPrice;
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
            Validation.AddressValidation(addressTextBox, errorProvider);
        }

        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.CityValidation(cityTextBox, errorProvider);
        }

        private void stateTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.StateValidation(stateTextBox, errorProvider);
        }

        private void zipTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.ZipValidation(zipTextBox, errorProvider);
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            GeneralOperations.ConfirmName(nameTextBox, errorProvider);
        }

        private void cardNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            GeneralOperations.ConfirmNumber(cardNumberTextBox, errorProvider);
        }

        private void monthCombBox_Validating(object sender, CancelEventArgs e)
        {
            GeneralOperations.ConfirmExpirationDate(monthCombBox, yearComboBox, errorProvider);
        }

        private void yearComboBox_Validating(object sender, CancelEventArgs e)
        {
            GeneralOperations.ConfirmExpirationDate(monthCombBox, yearComboBox, errorProvider);
        }
    }
}
