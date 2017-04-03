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
            CustomerInformation newCustomer = new CustomerInformation();        //Create a newCustomer object to hold Customer information

            newCustomer.Username = usernameInputTextBox.Text;           //Set the newCustomer objet's username to what the user has inputed
            newCustomer.Password = PasswordOperations.AccountPasswordHashing(passwordInputTextBox.Text);       //Check password and hash / salt it to make sure that they match with what is in table  

            //Validation to make sure username is correct
            if (Validation.UsernameValidation(usernameInputTextBox, errorProvider))
            {
                //Method to select a user and send them to the appropriate screens
                if (DatabaseOperationsUser.SelectUser(newCustomer, passwordInputTextBox))
                {
                    //Send to Employee screen if "Admin" logged in
                    if (usernameInputTextBox.Text == "Admin")
                    {
                        //Hide this form so the user can no longer see it as it is no longer needed
                        this.Hide();

                        //Go to the employee screen as the user has requested and verified to go there
                        EmployeeScreenForm employeeScreenForm = new EmployeeScreenForm();
                        employeeScreenForm.Show();
                    }

                    //Send to customer screen if any other user
                    else
                    {
                        //Hide this form so the user can no longer see it as it is no longer needed
                        this.Hide();

                        //Go to the main form as the user has requested and verified to go there
                        MainApplicationForm mainApplicationForm = new MainApplicationForm();
                        mainApplicationForm.mainApplicationUsername = usernameInputTextBox.Text;            //Send customer's username to this form for future usage
                        mainApplicationForm.Show();
                    }
                }
                else
                {
                    //Let the user know that there username or password is incorrect
                    MessageBox.Show("Username or Password incorrect!");
                }
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