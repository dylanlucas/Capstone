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
    public partial class ContactScreenForm : Form
    {
        public ContactScreenForm()
        {
            InitializeComponent();
        }

        public string contactScreenUsernameHolder { get; set; }             //Hold the username of the user who logged on

        string email;           //Pass a variable to hold email information of the currently logged in user

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Make sure that the fields are not empty and if so send information back
            if (!string.IsNullOrEmpty(feedbackTextBox.Text))
            {
                //Call email operations class and feedbackemail method to let the user email the company through the application with any and all feedback
                //about the company
                EmailOperations.FeedBackEmail(email, contactScreenUsernameHolder, feedbackTextBox);

                //Let the user know that the Feedback has been sent
                MessageBox.Show("Feedback has been sent, thank you!");
            }
        }
    }
}
