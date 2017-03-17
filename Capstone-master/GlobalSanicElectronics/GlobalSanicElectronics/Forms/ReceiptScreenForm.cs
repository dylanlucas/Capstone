using System;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    public partial class ReceiptScreenForm : Form
    {
        public ReceiptScreenForm()
        {
            InitializeComponent();
        }        
                                                            
        public string username { get; set; }
        public double price { get; set; }
        public string console { get; set; }
        public string computer { get; set; }
        public string tablet { get; set; }
        public string television { get; set; }

        Random orderNumber = new Random();        

        double number;
        string email;

        private void ReceiptScreen_Load(object sender, EventArgs e)
        {
            email = DatabaseOperations.GetUserEmail(username);

            Cart userCart = DatabaseOperationsCart.GetCart(username);

            DatabaseOperationsCart.DeleteEntireCart(username);

            //Get Order Number with the Random Class
            number = orderNumber.Next();

            //Display the Order Number in the label
            orderNumberDisplayLabel.Text = number.ToString();

            //Update the Purchase table and add the user's Order number to the table
            DatabaseOperationsPurchases.UpdatePurchases(username, number, computer, console, television, tablet, price);

            EmailOperations.UserOrderCreated(email, username, price, number, userCart);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go to the MainApplication since the user has successfully logged in and created there account
            MainApplicationForm mainApplicationForm = new MainApplicationForm();
            mainApplicationForm.mainApplicationUsername = username;
            mainApplicationForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application out when the user clicks Exit
            this.Close();
        }
    }
}
