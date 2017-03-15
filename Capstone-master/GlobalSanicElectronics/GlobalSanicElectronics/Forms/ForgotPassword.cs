using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        double temporaryPassword;

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Check for Email
            bool emailVerified;

            if (emailVerified = DatabaseOperations.ForgotPasswordEmail(usernameTextBox, emailTextBox))
            {
                DatabaseOperations.ForgotPassword(usernameTextBox);

                double temporaryPassword = DatabaseOperations.ForgotPassword(usernameTextBox);

                EmailOperations.ForgotPassword(emailTextBox, usernameTextBox, temporaryPassword);

                MessageBox.Show("Information on what to do to recover your password has been sent to the address");
            }
            else
            {
                MessageBox.Show("Information on what to do to recover your password has been sent to the address");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            LoginScreen loginScreenForm = new LoginScreen();
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
