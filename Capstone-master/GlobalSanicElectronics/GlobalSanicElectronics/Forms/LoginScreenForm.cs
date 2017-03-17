using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class LoginScreenForm : Form
    {
        public LoginScreenForm()
        {
            InitializeComponent();         
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            CustomerInformation newCustomer = new CustomerInformation();

            newCustomer.Username = usernameInputTextBox.Text;
            newCustomer.Password = PasswordOperations.AccountPasswordHashing(passwordInputTextBox.Text);         

            if (DatabaseOperationsUser.SelectUser(newCustomer, passwordInputTextBox))
            {
                if (usernameInputTextBox.Text == "Admin")
                {
                    //Hide this form so the user can no longer see it as it is no longer needed
                    this.Hide();

                    //Go to the employee screen as the user has requested and verified to go there
                    EmployeeScreenForm employeeScreenForm = new EmployeeScreenForm();
                    employeeScreenForm.Show();
                }
                else
                {
                    //Hide this form so the user can no longer see it as it is no longer needed
                    this.Hide();

                    //Go to the main form as the user has requested and verified to go there
                    MainApplicationForm mainApplicationForm = new MainApplicationForm();
                    mainApplicationForm.mainApplicationUsername = usernameInputTextBox.Text;
                    mainApplicationForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Username or Password incorrect!");
            }                       
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application out when the user clicks Exit
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void forgotPassButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Show();
        }
    }
}