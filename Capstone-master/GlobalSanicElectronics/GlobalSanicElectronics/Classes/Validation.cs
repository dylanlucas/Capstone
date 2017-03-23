using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public static class Validation
    {
        private static readonly string containsLowerMessage = "Password needs to have at least one lowercase letter";
        private static readonly string containsUpperMessage = "Password needs to have at least one uppercase letter";
        private static readonly string containsLengthMessage = "Password needs to be at least 8 characters long";
        private static readonly string containsNumbersMessage = "Password needs to contain at least one number";
        private static readonly string containsCharMessage = "Password needs to contain one special character";
        private static readonly string numbersOnlyMessage = "Zip should only be numbers ranging from 0-9";

        public static bool UsernameValidation(TextBox username, ErrorProvider error)
        {
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                error.SetError(username, "This field can not be empty.");
                return false;
            }

            error.SetError(username, string.Empty);
            return true;
        }

        public static bool EmailValidation(TextBox email, ErrorProvider error)
        {
            if (string.IsNullOrWhiteSpace(email.Text))
            {
                error.SetError(email, "This field can not be empty.");
                return false;
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(email.Text);
                    error.SetError(email, string.Empty);

                    return true;
                }
                catch (FormatException)
                {
                    error.SetError(email, "Correct format \n\n correctformat@this.com");
                    return false;
                }
            }
        }

        public static bool BirthValidation(TextBox dob, ErrorProvider error)
        {
            if (string.IsNullOrWhiteSpace(dob.Text))
            {
                error.SetError(dob, "This field can not be empty.");
                return false;
            }

            error.SetError(dob, string.Empty);
            return true;
        }

        public static bool AddressValidation(TextBox address, ErrorProvider error)
        {
            if (string.IsNullOrWhiteSpace(address.Text))
            {
                error.SetError(address, "This field can not be empty.");
                return false;
            }

            error.SetError(address, string.Empty);
            return true;
        }

        public static bool CityValidation(TextBox city, ErrorProvider error)
        {
            if (string.IsNullOrWhiteSpace(city.Text))
            {
                error.SetError(city, "This field can not be empty.");
                return false;
            }

            error.SetError(city, string.Empty);
            return true;
        }

        public static bool StateValidation(TextBox state, ErrorProvider error)
        {
            if (string.IsNullOrWhiteSpace(state.Text))
            {
                error.SetError(state, "This field can not be empty.");
                return false;
            }
            else if (state.Text.Length < 2)
            {
                error.SetError(state, "Invalid state.");
                return false;
            }
            else if (state.Text.Length > 2)
            {
                error.SetError(state, "Invalid state.");
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(state.Text, AccountRegex.lettersOnly))
            {
                error.SetError(state, "This field can only contain letters");
                return false;
            }

            error.SetError(state, string.Empty);
            return true;
        }

        public static bool ZipValidation(TextBox zip, ErrorProvider error)
        {
            if (string.IsNullOrWhiteSpace(zip.Text))
            {
                error.SetError(zip, "This field can not be empty.");
                return false;
            }
            else if (zip.Text.Length < 5)
            {
                error.SetError(zip, "Invalid zip.");
                return false;
            }
            else if (zip.Text.Length > 5)
            {
                error.SetError(zip, "Invalid zip.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(zip.Text, AccountRegex.numbersOnly))
            {
                error.SetError(zip, numbersOnlyMessage);
                return false;
            }

            error.SetError(zip, string.Empty);
            return true;
        }

        public static bool PasswordValidation(TextBox password, ErrorProvider error)
        {
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                error.SetError(password, "This field can not be empty.");
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password.Text, AccountRegex.containsLowerCase))
            {
                error.SetError(password, containsLowerMessage);
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password.Text, AccountRegex.containsUppercase))
            {
                error.SetError(password, containsUpperMessage);
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password.Text, AccountRegex.properLength))
            {
                error.SetError(password, containsLengthMessage);
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password.Text, AccountRegex.containsNumber))
            {
                error.SetError(password, containsNumbersMessage);
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password.Text, AccountRegex.containsSpecialChar))
            {
                error.SetError(password, containsCharMessage);
                return false;
            }

            error.SetError(password, string.Empty);
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
