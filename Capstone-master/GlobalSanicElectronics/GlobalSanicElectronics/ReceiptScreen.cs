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
    public partial class ReceiptScreen : Form
    {
        public ReceiptScreen()
        {
            InitializeComponent();
        }

        //Declare variable for Database
        System.Data.SqlClient.SqlConnection sqlConnectionLink =
            new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dylan\\Source\\Repos\\Capstone\\Capstone-master\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True");
                                                    
        public string username { get; set; }
        public double price { get; set; }

        Random orderNumber = new Random();

        double number;

        private void ReceiptScreen_Load(object sender, EventArgs e)
        {
            number = orderNumber.Next();

            orderNumberDisplayLabel.Text = number.ToString();

            System.Data.SqlClient.SqlCommand updateCart = new System.Data.SqlClient.SqlCommand();
            updateCart.CommandType = System.Data.CommandType.Text;
            updateCart.CommandText = "INSERT into Purchases (CustomerName, OrderNumber) VALUES ('" + username + "' , '" + number.ToString() + "')";

            updateCart.Connection = sqlConnectionLink;
            sqlConnectionLink.Open();
            updateCart.ExecuteNonQuery();
            sqlConnectionLink.Close();
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
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.MyProperty = username;
            mainApplicationForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application out when the user clicks Exit
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {          

        }
    }
}
