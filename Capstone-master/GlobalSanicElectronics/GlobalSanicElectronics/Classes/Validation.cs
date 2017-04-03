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
        //Error message to tell that the password must contain at least one lowercase letter
        private static readonly string containsLowerMessage = "Password needs to have at least one lowercase letter";
        
        //Error message to tell that the password must contain at least one uppercase letter
        private static readonly string containsUpperMessage = "Password needs to have at least one uppercase letter";

        //Error message to tell that the password must be at least 8 characters long
        private static readonly string containsLengthMessage = "Password needs to be at least 8 characters long";

        //Error message to tell that the password must contain at least one number 
        private static readonly string containsNumbersMessage = "Password needs to contain at least one number";

        //Error message to tell that the password must contain at least one special character
        private static readonly string containsCharMessage = "Password needs to contain one special character";

        //Error message that the zip code should only contain numbers
        private static readonly string numbersOnlyMessage = "Zip should only be numbers ranging from 0-9";

        //Validation method for username to check certain conditions
        //Whether username is null and if it contains any special characters
        public static bool UsernameValidation(TextBox username, ErrorProvider error)
        {
            //Validation check to see if the username is empty or not
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                //Send error message that username's cannot be empty
                error.SetError(username, "This field can not be empty.");
                return false;
            }

            //Validation to check to see if the username has any special characters
            else if (!System.Text.RegularExpressions.Regex.IsMatch(username.Text, AccountRegex.noSpecialCharacters))
            {
                //Send error message that the username cannot contain any special characters
                error.SetError(username, "This field can only have letters from A-Z, numbers ranging from 0-9, or an _");
                return false;
            }

            //Send no error message as the username passes all validations
            error.SetError(username, string.Empty);
            return true;
        }

        //Validation method for the email to check certain conditions
        //Whether the email is null and is in correct format
        public static bool EmailValidation(TextBox email, ErrorProvider error)
        {
            //Validation to make sure that the email is not empty
            if (string.IsNullOrWhiteSpace(email.Text))
            {
                //Send error message that the email cannot be empty
                error.SetError(email, "This field can not be empty.");
                return false;
            }
            else
            {
                try
                {
                    //Send back positive information that the username is in correct format
                    MailAddress mail = new MailAddress(email.Text);
                    error.SetError(email, string.Empty);

                    return true;
                }
                catch (FormatException)
                {
                    //If mail in the above try part is not in correct format, then send error message letting user know
                    error.SetError(email, "Correct format \n\n correctformat@this.com");
                    return false;
                }
            }
        }

        //Validation method for DOB to check certain conditions
        //Whether the DOB is null
        public static bool BirthValidation(TextBox dob, ErrorProvider error)
        {
            //Validation method to make sure date of birth is not empty
            if (string.IsNullOrWhiteSpace(dob.Text))
            {
                //Send error message to tell user date of birth cannot be empty
                error.SetError(dob, "This field can not be empty.");
                return false;
            }
            
            //Send back positive information and send no error message as DOB is correct
            error.SetError(dob, string.Empty);
            return true;
        }

        //Validation method for the Address to check certain conditions
        //Whether the Address is null
        public static bool AddressValidation(TextBox address, ErrorProvider error)
        {
            //Validation to make sure address entered is not null
            if (string.IsNullOrWhiteSpace(address.Text))
            {
                //Send error message telling the user that this address cannot be empty
                error.SetError(address, "This field can not be empty.");
                return false;
            }

            //Set error message to nothing as all information is correct for the Address
            error.SetError(address, string.Empty);
            return true;
        }

        //Validation method for the City to check certain conditions
        //Whether the City is null
        public static bool CityValidation(TextBox city, ErrorProvider error)
        {
            //Validation method to make sure city is not null
            if (string.IsNullOrWhiteSpace(city.Text))
            {
                //Send error message telling that the City field cannot be empty
                error.SetError(city, "This field can not be empty.");
                return false;
            }

            //City field is correct so set error message to nothing and send back positive information
            error.SetError(city, string.Empty);
            return true;
        }

        //Validation method for the State to check certain conditions
        //Whether state is null, is only 2 characters long, and only letters
        public static bool StateValidation(TextBox state, ErrorProvider error)
        {
            //Validation to make sure that State is not empty
            if (string.IsNullOrWhiteSpace(state.Text))
            {
                //Send error message telling State field cannot be empty
                error.SetError(state, "This field can not be empty.");
                return false;
            }

            //Validation to make sure that the State is less than 2 Characters
            else if (state.Text.Length < 2)
            {
                //Send error message to let user know state is to short
                error.SetError(state, "Invalid state.");
                return false;
            }

            //Validation to make sure that State is not greater than 2 characters
            else if (state.Text.Length > 2)
            {
                //Send error message to let the user know state is to long
                error.SetError(state, "Invalid state.");
                return false;
            }

            //Validation to make sure state only contains letters and nothing else
            else if (!System.Text.RegularExpressions.Regex.IsMatch(state.Text, AccountRegex.lettersOnly))
            {
                //Send error message to let the user know that State is not in valid format
                error.SetError(state, "This field can only contain letters");
                return false;
            }

            //If all is correct set error message to nothing and return true
            error.SetError(state, string.Empty);
            return true;
        }

        //Validation method for the Zip to check certain conditions
        //Whether the zip is null, if it is 5 characters long, and is numbers only
        public static bool ZipValidation(TextBox zip, ErrorProvider error)
        {
            //Validation to make sure that the zip is not null
            if (string.IsNullOrWhiteSpace(zip.Text))
            {
                //Send error message to make sure that the zip is not empty
                error.SetError(zip, "This field can not be empty.");
                return false;
            }

            //Validation to make sure that zip is not less than 5 characters
            else if (zip.Text.Length < 5)
            {
                //Send error message to let the Zip information is at least 5 characters
                error.SetError(zip, "Invalid zip.");
                return false;
            }

            //Validation to make sure that the zip is not greater than 5 characters
            else if (zip.Text.Length > 5)
            {
                //Send error message to let the zip information is at least 5 characters
                error.SetError(zip, "Invalid zip.");
                return false;
            }

            //Validation to make sure that the zip only contains numbers
            else if (!System.Text.RegularExpressions.Regex.IsMatch(zip.Text, AccountRegex.numbersOnly))
            {
                //Send error message that the zip only contains numbers
                error.SetError(zip, numbersOnlyMessage);
                return false;
            }

            //If all is correct set no error message and return true
            error.SetError(zip, string.Empty);
            return true;
        }

        //Validation method for the password to check certain conditions
        //Whether the password is null, contains at least one lower letter, one upper character
        //Is at least 8 characters long, has at least one number, and contains one special character
        public static bool PasswordValidation(TextBox password, ErrorProvider error)
        {
            //Validation to make sure password is not null
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                //Send error message to tell user that password cannot be empty
                error.SetError(password, "This field can not be empty.");
                return false;
            }

            //Validation to make sure that the password contains one lower case letter
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password.Text, AccountRegex.containsLowerCase))
            {
                //Send error message to tell the user that password needs 1 lower case letter
                error.SetError(password, containsLowerMessage);
                return false;
            }

            //Validation to make sure that the password contains one upper case letter
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password.Text, AccountRegex.containsUppercase))
            {
                //Send error message to tell the user that password needs 1 upper case letter
                error.SetError(password, containsUpperMessage);
                return false;
            }

            //Validation to make sure that the password is 8 characters long
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password.Text, AccountRegex.properLength))
            {
                //Send error message telling that the password is to short
                error.SetError(password, containsLengthMessage);
                return false;
            }

            //Validation to make sure that the password contains at least one number in it
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password.Text, AccountRegex.containsNumber))
            {
                //Send error message telling that password does not contain a number
                error.SetError(password, containsNumbersMessage);
                return false;
            }

            //Validation to make sure that the password contains at least one character in it
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password.Text, AccountRegex.containsSpecialChar))
            {
                //Send the error message telling that the password needs at least one special character
                error.SetError(password, containsCharMessage);
                return false;
            }

            //Send no error message as all information is correct and return true
            error.SetError(password, string.Empty);
            return true;
        }

        //Regex to check certain conditions on Password field and other fields
        public static class AccountRegex
        {
            //Regex to make sure there are no special characters
            public static readonly string noSpecialCharacters = @"^[A-Za-z0-9.\s_-]+$";

            //Regex to make sure that there is only numbers
            public static readonly string numbersOnly = @"^[\d]{5}$";

            //Regex to make sure that the string only contains numbers
            public static readonly string containsNumber = @"[0-9]+";

            //Regex to make sure string contains at least one uppercase letter
            public static readonly string containsUppercase = @"[A-Z]+";

            //Regex to make sure that the field is at least 8 characters long
            public static readonly string properLength = @".{8,15}";

            //Regex to make sure that the string has at least one lower case letter
            public static readonly string containsLowerCase = @"[a-z]+";

            //Regex to make sure that the string is only letters
            public static readonly string lettersOnly = @"^[a-zA-Z ]+$";

            //Regex to make sure that the field contains special characters
            public static readonly string containsSpecialChar = @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]";
        }
    }
}
