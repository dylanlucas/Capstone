using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        double temporaryPassword;       //Hold a temporary password information for the user

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Check for Email
            bool emailVerified;

            //Method if the email is verified and true
            if (emailVerified = DatabaseOperations.ForgotPasswordEmail(usernameTextBox, emailTextBox))
            {
                //Send the temporaryPassword information to the ForgotPassword databaseoperation
                double temporaryPassword = DatabaseOperations.ForgotPassword(usernameTextBox);

                //Call the email operation for forgot password so the user can get a corresponding email with information on how to update there passwword
                EmailOperations.ForgotPassword(emailTextBox, usernameTextBox, temporaryPassword);

                //Show a messagebox to let the user know (regardless if true or not) that information on what to do has been sent to them
                MessageBox.Show("Information on what to do to recover your password has been sent to the address");
            }
            else
            {
                //Show a messagebox to let the user know (regardless if true or not) that information on what to do has been sent to them
                MessageBox.Show("Information on what to do to recover your password has been sent to the address");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            LoginScreenForm loginScreenForm = new LoginScreenForm();
            loginScreenForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = confirmButton;
        }
    }
}
