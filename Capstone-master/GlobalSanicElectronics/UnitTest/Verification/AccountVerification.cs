using System;
using System.Net.Mail;


namespace UnitTest
{
    class AccountCreationVerification
    {
        public static bool UsernameValidation(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            return true;
        }

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

        public static bool BirthValidation(string dob)
        {
            if (string.IsNullOrWhiteSpace(dob))
            {
                return false;
            }

            return true;
        }

        public static bool AddressValidation(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                return false;
            }

            return true;
        }

        public static bool CityValidation(string city)
        {
            if(string.IsNullOrWhiteSpace(city))
            {
                return false;
            }

            return true;
        }

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
