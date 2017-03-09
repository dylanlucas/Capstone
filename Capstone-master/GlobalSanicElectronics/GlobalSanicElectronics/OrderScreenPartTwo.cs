using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace GlobalSanicElectronics
{
    public partial class OrderScreenPartTwo : Form
    {
        public OrderScreenPartTwo()
        {
            InitializeComponent();
        }

        public double userPrice { get; set; }
        public string userName { get; set; }
        public string console { get; set; }
        public string computer { get; set; }
        public string tablet { get; set; }
        public string television { get; set; }   

        private void OrderScreenPartTwocs_Load(object sender, EventArgs e)
        {
            //Default the shipping option
            shippingTwoRadioButton.Checked = true;

            //Show the user's current total before shipping
            totalPaymentDisplayLabel.Text = userPrice.ToString();

            //Fill the yearComboBox with the appropriate years
            for (int year = DateTime.Today.Year; year < DateTime.Today.Year + 10; year++)
            {
                yearComboBox.Items.Add(year.ToString());
            }

            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dylan\\Source\\Repos\\Capstone\\Capstone-master\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string selectSql = "SELECT Address, City, State, Zip FROM CustomerInformation WHERE Username= '" + userName + "'";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        addressTextBox.Text = (reader["Address"].ToString());
                        cityTextBox.Text = (reader["City"].ToString());
                        stateTextBox.Text = (reader["State"].ToString());
                        zipTextBox.Text = (reader["Zip"].ToString());
                    }
                }
            }
            finally
            {
                con.Close();
            }
        }

        private void confirmShippingInformationButton_Click(object sender, EventArgs e)
        {
            string message = "Is the shipping information currently displayed correct?";
            string caption = "Confirm Shipping Address";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if(result == DialogResult.Yes)
            {
                shippingGroupBox.Enabled = false;
            }
        }

        private void confirmPaymentButton_Click(object sender, EventArgs e)
        {
            if ( nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter the name on the card");
            }
            else if (cardNumberTextBox.Text == "")
            {
                MessageBox.Show("Please enter a card number");
            }
            else if (monthCombBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a month");
            }
            else if (yearComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a year");
            }
            else
            {
                int year = int.Parse(yearComboBox.GetItemText(yearComboBox.SelectedItem));
                int month = int.Parse(monthCombBox.GetItemText(monthCombBox.SelectedItem));

                if (year == DateTime.Now.Year && month <= DateTime.Now.Month)
                {
                    MessageBox.Show("Invalid Expiration Date");
                }
                else
                {
                    paymentGroupBox.Enabled = false;
                }
            }
        }

        private void cardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void expirationDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
            
        }

        private void cardNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string value = cardNumberTextBox.Text;

            if (!string.IsNullOrEmpty(value) && e.KeyCode != Keys.Back)
            {
                value = value.Replace("-", "");
                string divide = Regex.Replace(value, @"\d\d\d\d(?!$)", "$0-");
                cardNumberTextBox.Text = divide;
                cardNumberTextBox.SelectionStart = cardNumberTextBox.Text.Length;
            }
        }

        private void confirmShippingSpeedButton_Click(object sender, EventArgs e)
        {
            if (shippingOneRadioButton.Checked)
            {
                userPrice += 30.00;
            }

            string message = "Are you sure this is the shipping speed you would like?";
            string caption = "Confirm Shipping Speed";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                shippingSpeedGroupBox.Enabled = false;
            }            

            totalPaymentDisplayLabel.Text = "$" + userPrice.ToString();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            OrderScreen orderScreenForm = new OrderScreen();
            orderScreenForm.orderProperty = userName;
            orderScreenForm.overallPrice = userPrice;
            orderScreenForm.Show();
        }

        private void confirmPurchaseButton_Click(object sender, EventArgs e)
        {
            if (shippingGroupBox.Enabled == false && shippingSpeedGroupBox.Enabled == false && paymentGroupBox.Enabled == false)
            {
                //Hide this form so the user can no longer see it as it is no longer needed
                this.Hide();

                //Go to the Receipt Form since the user has requested to
                ReceiptScreen receiptScreenForm = new ReceiptScreen();
                receiptScreenForm.username = userName;
                receiptScreenForm.price = userPrice;
                receiptScreenForm.console = console;
                receiptScreenForm.computer = computer;
                receiptScreenForm.tablet = tablet;
                receiptScreenForm.television = television;
                receiptScreenForm.Show();
            }
            else
            {
                MessageBox.Show("Please ensure all fields have been confirmed");
            }
        }
    }
}
