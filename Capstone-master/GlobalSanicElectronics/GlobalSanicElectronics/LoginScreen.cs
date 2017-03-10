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
using System.Configuration;

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
            string salt = "WquZ012C";

            var bytes = new UTF8Encoding().GetBytes(salt + passwordInputTextBox.Text);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }

            string passHash = Convert.ToBase64String(hashBytes);

            //Check for username & Password            
            SqlCommand cmd = new SqlCommand("SELECT * From CustomerInformation WHERE Username LIKE @Username AND Password = @Password;");
            cmd.Parameters.AddWithValue("@Username", usernameInputTextBox.Text);
            cmd.Parameters.AddWithValue("@Password", passHash);
            cmd.Connection = DatabaseOperations.sqlConnectionLink;
            DatabaseOperations.sqlConnectionLink.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            DatabaseOperations.sqlConnectionLink.Close();

            bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            if (loginSuccessful)
            {
                if (usernameInputTextBox.Text == "Admin")
                {
                    //Hide this form so the user can no longer see it as it is no longer needed
                    this.Hide();

                    //Go to the employee screen as the user has requested and verified to go there
                    EmployeeScreen employeeScreenForm = new EmployeeScreen();
                    employeeScreenForm.Show();
                }
                else
                {
                    //Hide this form so the user can no longer see it as it is no longer needed
                    this.Hide();

                    //Go to the main form as the user has requested and verified to go there
                    MainApplication mainApplicationForm = new MainApplication();
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

        //Method to allow the user to push enter instead of actually clicking Login.
        private void passwordInputTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = loginButton;
        }

        //Method to allow the user to push enter instead of actually clicking Login.
        private void usernameInputTextBox_TextChanged(object sender, EventArgs e)
        {
            //Takes "Enter" key and allows it to be a substitute for the submit button or pushes the submit button for you instead of having to click it.
            this.AcceptButton = loginButton;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
