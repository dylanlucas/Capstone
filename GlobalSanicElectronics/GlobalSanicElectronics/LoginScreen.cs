using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GlobalSanicElectronics
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Declare connection to database
            System.Data.SqlClient.SqlConnection sqlConnectionLink =
                new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=I:\\Capstone\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True");

            //Declare Variables
            Int32 verifyUsernameAndPassword;

            //Check for username & Password
            String validation = "SELECT * From CustomerInformation WHERE Username LIKE '" + usernameInputTextBox.Text + "' AND Password LIKE '" + passwordInputTextBox.Text + "'";
            SqlCommand validateInputCommand = new SqlCommand(validation, sqlConnectionLink);
            sqlConnectionLink.Open();
            verifyUsernameAndPassword = Convert.ToInt32(validateInputCommand.ExecuteScalar());
            sqlConnectionLink.Close();

            if (verifyUsernameAndPassword > 0 )
            {
                MessageBox.Show("Thank you for logging into Global Sanic Electronics! You will now be redirected to the main application");

                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();

                //Go to the MainApplication since the user has successfully logged in
                MainApplication mainApplicationForm = new MainApplication();
                mainApplicationForm.Show();
            }
            else
            {
                MessageBox.Show("The username or password you have entered is not correct! Please make sure what you're typing is correct");
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
    }
}
