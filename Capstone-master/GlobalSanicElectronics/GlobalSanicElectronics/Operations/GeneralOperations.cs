using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    class GeneralOperations
    {
        //Method to add more information to the price depending on the bundle or warranty chosen by the user
        public static double UserPrice(RadioButton consoleBundleOne, RadioButton consoleBundleTwo, RadioButton consoleBundleThree,
            RadioButton consoleWarrantyOne, RadioButton consoleWarrantyTwo, RadioButton consoleWarrantyThree,
            RadioButton computerWarrantyOne, RadioButton computerWarrantyTwo, RadioButton computerWarrantyThree,
            RadioButton tabletWarrantyOne, RadioButton tabletWarrantyTwo, RadioButton tabletWarrantyThree,
            RadioButton televisionWarrantyOne, RadioButton televisionWarrantyTwo, RadioButton televisionWarrantyThree,
            double userPrice)
        {
            //Adding Console Bundle price information to the userPrice variable so it has an accumulated overall price
            if (consoleBundleOne.Checked)
            {
                userPrice += 30.00;
            }
            else if (consoleBundleTwo.Checked)
            {
                userPrice += 45.00;
            }
            else if (consoleBundleThree.Checked)
            {
                userPrice += 60.00;
            }

            //Adding Console Warranty price information to the userPrice variable so it has an accumulated overall price
            if (consoleWarrantyOne.Checked)
            {
                userPrice += 30.00;
            }
            else if (consoleWarrantyTwo.Checked)
            {
                userPrice += 45.00;
            }
            else if (consoleWarrantyThree.Checked)
            {
                userPrice += 60.00;
            }

            //Adding Computer Warranty price information to the userPrice variable so it has an accumulated overall price
            if (computerWarrantyOne.Checked)
            {
                userPrice += 30.00;
            }
            else if (computerWarrantyTwo.Checked)
            {
                userPrice += 45.00;
            }
            else if (computerWarrantyThree.Checked)
            {
                userPrice += 60.00;
            }

            //Adding Tablet Warranty price information to the userPrice variable so it has an accumulated overall price
            if (tabletWarrantyOne.Checked)
            {
                userPrice += 30.00;
            }
            else if (tabletWarrantyTwo.Checked)
            {
                userPrice += 45.00;
            }
            else if (tabletWarrantyThree.Checked)
            {
                userPrice += 60.00;
            }

            //Adding Television Warranty price information to the userPrice variable so it has an accumulated overall price
            if (televisionWarrantyOne.Checked)
            {
                userPrice += 30.00;
            }
            else if (televisionWarrantyTwo.Checked)
            {
                userPrice += 45.00;
            }
            else if (televisionWarrantyThree.Checked)
            {
                userPrice += 60.00;
            }

            return userPrice;
        }        

        //Method to get the Default information regarding what is already selected / checked on the orderscreenpartTwo
        public static void DefaultInformation(RadioButton shippingTwoRadioButton, Label totalPaymentDisplayLabel, ComboBox yearComboBox, double userPrice)
        {
            //Default the shipping option
            shippingTwoRadioButton.Checked = true;

            //Default the shipping option
            shippingTwoRadioButton.Checked = true;

            //Show the user's current total before shipping
            totalPaymentDisplayLabel.Text = "$" + userPrice.ToString();

            //Fill the yearComboBox with the appropriate years
            for (int year = DateTime.Today.Year; year < DateTime.Today.Year + 10; year++)
            {
                yearComboBox.Items.Add(year.ToString());
            }
        }

        //Method to make sure the user know's that the shipping information that they have entered cannot be chagned once they confirm it
        public static void ConfirmShipping(GroupBox shippingGroupBox)
        {
            string message = "Is the shipping information currently displayed correct?";
            string caption = "Confirm Shipping Address";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                shippingGroupBox.Enabled = false;
            }
        }

        //Method to make sure that the name entered is not null and only contains letters
        public static bool ConfirmName(TextBox nameTextBox, ErrorProvider error)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                error.SetError(nameTextBox, "This field can not be empty.");
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(nameTextBox.Text, Regex.lettersOnly))
            {
                error.SetError(nameTextBox, "This field can only contain letters.");
                return false;
            }

            error.SetError(nameTextBox, string.Empty);
            return true;
        }

        //Method to make sure that the Card Number is not null and is not greater than 16 characters
        public static bool ConfirmNumber(TextBox cardNumberTextBox, ErrorProvider error)
        {
            if (string.IsNullOrWhiteSpace(cardNumberTextBox.Text))
            {
                error.SetError(cardNumberTextBox, "This field can not be empty.");
                return false;
            }
            else if (cardNumberTextBox.TextLength < 16)
            {
                error.SetError(cardNumberTextBox, "Incorrect Card Number.");
                return false;
            }

            error.SetError(cardNumberTextBox, string.Empty);
            return true;
        }

        //Method to make sure that the expiration date on the card is not empty and is a valid date, meaning before this month of this year is not valid
        public static bool ConfirmExpirationDate(ComboBox monthCombBox, ComboBox yearComboBox, ErrorProvider error)
        {
            if (monthCombBox.SelectedItem == null || yearComboBox.SelectedItem == null)
            {
                error.SetError(monthCombBox, "This field cannot be empty.");
                error.SetError(yearComboBox, "This field can not be empty.");
                return false;
            }
            else
            {
                int year = int.Parse(yearComboBox.GetItemText(yearComboBox.SelectedItem));
                int month = int.Parse(monthCombBox.GetItemText(monthCombBox.SelectedItem));

                if (year == DateTime.Now.Year && month <= DateTime.Now.Month)
                {
                    error.SetError(monthCombBox, "Invalid Expiration Date");
                    error.SetError(yearComboBox, "Invalid Expiration Date");
                    return false;
                }

                error.SetError(monthCombBox, string.Empty);
                error.SetError(yearComboBox, string.Empty);
                return true;
            }
        }

        //Method to let the user select a shipping speed and confirm that it cannot be changed once they click confirm
        public static void ConfirmShippingSpeed(RadioButton shippingOneRadioButton, double userPrice, GroupBox shippingSpeedGroupBox, Label totalPaymentDisplayLabel)
        {
            if (shippingOneRadioButton.Checked)
            {
                userPrice += 30.00;
            }

            string message = "Are you sure this is the shipping speed you would like?";
            string caption = "Confirm Shipping Speed";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                shippingSpeedGroupBox.Enabled = false;
            }

            totalPaymentDisplayLabel.Text = "$" + userPrice.ToString();
        }

        //Regex to make sure that certain strings only contain letters and numbers
        public static class Regex
        {
            public static readonly string lettersOnly = @"^[a-zA-Z ]+$";
            public static readonly string numbersOnly = "^[0-9]+$";
        }
    }
}
