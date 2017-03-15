using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class LaunchScreen : Form
    {
        public LaunchScreen()
        {
            InitializeComponent();
        }

        private void accCreateButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Open the AccountCreation form to allow the user to go further into the program and allow them to create there account
            AccountCreation accountCreationForm = new AccountCreation();
            accountCreationForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Open the LoginForm form to allow the user to go further into the program and allow them to login to there account
            LoginScreen loginForm = new LoginScreen();
            loginForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application out when the user clicks Exit
            this.Close();
        }

        private void LaunchScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
