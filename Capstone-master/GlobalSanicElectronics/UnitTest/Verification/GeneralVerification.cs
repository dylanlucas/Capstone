using System;

namespace UnitTest
{
    class GeneralVerification
    {
        public static bool ConfirmName(string nameTextBox)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox))
            {
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(nameTextBox, Regex.lettersOnly))
            {
                return false;
            }

            return true;
        }

        public static bool ConfirmNumber(string cardNumberTextBox)
        {
            if (string.IsNullOrWhiteSpace(cardNumberTextBox))
            {
                return false;
            }
            else if (cardNumberTextBox.Length < 16)
            {
                return false;
            }
            else if (cardNumberTextBox.Length > 16)
            {
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(cardNumberTextBox, Regex.numbersOnly))
            {
                return false;
            }

            return true;
        }

        public static bool ConfirmExpirationDate(string monthCombBox, string yearComboBox)
        {
            if (string.IsNullOrEmpty(monthCombBox) || string.IsNullOrEmpty(yearComboBox))
            {
                return false;
            }
            else
            {
                int year = int.Parse(yearComboBox);
                int month = int.Parse(monthCombBox);

                if (year == DateTime.Now.Year && month <= DateTime.Now.Month)
                {
                    return false;
                }
                return true;
            }
        }

        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public static class Regex
        {
            public static readonly string lettersOnly = @"^[a-zA-Z ]+$";
            public static readonly string numbersOnly = "^[0-9]+$";
        }
    }
}
