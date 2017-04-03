using System;
using System.Net.Mail;


namespace UnitTest
{
    class AccountCreationVerification
    {
        //Verification to make sure that a username is not null
        public static bool UsernameValidation(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            return true;
        }

        //Verification to make sure that email is not null
        public static bool EmailValidation(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(email);

                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
        }

        //Verification to make sure that the date of birth is not null
        public static bool BirthValidation(string dob)
        {
            if (string.IsNullOrWhiteSpace(dob))
            {
                return false;
            }

            return true;
        }

        //Verification to make sure that the address is not null
        public static bool AddressValidation(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                return false;
            }

            return true;
        }

        //Verification to make sure that the city is not null
        public static bool CityValidation(string city)
        {
            if(string.IsNullOrWhiteSpace(city))
            {
                return false;
            }

            return true;
        }

        //Verification to make sure that the state is not null
        //not less than 2 characters, not more than 2 characters
        //and is only letters
        public static bool StateValidation(string state)
        {
            if (string.IsNullOrWhiteSpace(state))
            {
                return false;
            }
            else if (state.Length < 2)
            {
                return false;
            }
            else if (state.Length > 2)
            {
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(state, AccountRegex.lettersOnly))
            {
                return false;
            }

            return true;
        }

        //Verification to make sure that the zip is not null
        //not less than 5 characters, not more than 5 characters
        //is only numbers
        public static bool ZipValidation(string zip)
        {
            if (string.IsNullOrWhiteSpace(zip))
            {
                return false;
            }
            else if (zip.Length < 5)
            {
                return false;
            }
            else if (zip.Length > 5)
            {
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(zip, AccountRegex.numbersOnly))
            {
                return false;
            }

            return true;
        }

        //Method to make sure password is not null
        //contains a lowercase letter, uppercase letter,
        //one digit, one special character, and is at least 8 digits long
        public static bool PasswordValidation(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password, AccountRegex.containsLowerCase))
            {
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password, AccountRegex.containsUppercase))
            {
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password, AccountRegex.properLength))
            {
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password, AccountRegex.containsNumber))
            {
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password, AccountRegex.containsSpecialChar))
            {
                return false;
            }

            return true;
        }

        //Regex to check for appropriate fields in the password, zip, and state fields
        public static class AccountRegex
        {
            public static readonly string numbersOnly = @"^[\d]{5}$";
            public static readonly string containsNumber = @"[0-9]+";
            public static readonly string containsUppercase = @"[A-Z]+";
            public static readonly string properLength = @".{8,15}";
            public static readonly string containsLowerCase = @"[a-z]+";
            public static readonly string lettersOnly = @"^[a-zA-Z ]+$";
            public static readonly string containsSpecialChar = @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]";
        }
    }
}
