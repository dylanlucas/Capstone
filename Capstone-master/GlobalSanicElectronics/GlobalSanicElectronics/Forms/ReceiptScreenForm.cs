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
                                                            
        public string username { get; set; }            //Get the username of the user
        public double price { get; set; }               //Get the price information of the user
        public string console { get; set; }             //Get information of whether the user has a console in it
        public string computer { get; set; }            //Get information of whether the user has a computer in it
        public string tablet { get; set; }              //Get information of whether the user has a tablet in it
        public string television { get; set; }          //Get information of whether the user has a television in it

        Random orderNumber = new Random();              //Create a order number that is random from the random class

        double number;                      //Double to hold the orderNumber
        string email;                       //Hold the user's email information

        private void ReceiptScreen_Load(object sender, EventArgs e)
        {
            //DatabaseOpeartion to get the User's email
            email = DatabaseOperations.GetUserEmail(username);

            //Get the user's cart from the GetCart DatabseOperation
            Cart userCart = DatabaseOperationsCart.GetCart(username);

            //Delte the user's cart
            DatabaseOperationsCart.DeleteEntireCart(username);

            //Get Order Number with the Random Class
            number = orderNumber.Next();

            //Display the Order Number in the label
            orderNumberDisplayLabel.Text = number.ToString();

            //Update the Purchase table and add the user's Order number to the table
            DatabaseOperationsPurchases.UpdatePurchases(username, number, computer, console, television, tablet, price);

            //Send an email to the user that the order has been created
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
            mainApplicationForm.mainApplicationUsername = username;         //Send the username of the user to the mail application
            mainApplicationForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application out when the user clicks Exit
            this.Close();
        }
    }
}
