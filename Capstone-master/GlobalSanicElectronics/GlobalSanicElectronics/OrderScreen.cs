﻿using System;
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
    public partial class OrderScreen : Form
    {
        public OrderScreen()
        {
            InitializeComponent();
        }

        //Declare variables
        double userPrice = 0;

        public string orderProperty { get; set; }        
        public double overallPrice { get; set; }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.MyProperty = orderProperty;
            mainApplicationForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the entire application
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Close the application if the user decides to push the big red X
            System.Windows.Forms.Application.Exit();
        }

        private void cartBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.gSEDatabaseDataSet.Cart);

            var select = "SELECT Console, Computer, Tablet, Television, Brand, Price FROM Cart WHERE Username= '" + orderProperty + "'";
            var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dylan\\Source\\Repos\\Capstone\\Capstone-master\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True");
            var dataAdapter = new SqlDataAdapter(select, connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            cartDataGridView.ReadOnly = true;
            cartDataGridView.DataSource = ds.Tables[0];

            cartDataGridView.SelectAll();

            if (cartDataGridView.RowCount > 0)
            {
                var lastRow = cartDataGridView.Rows[cartDataGridView.RowCount - 1];
                lastRow.Selected = false;
            }

            foreach (DataGridViewRow row in cartDataGridView.SelectedRows)
            {
                string console = row.Cells[0].Value.ToString();
                string computer = row.Cells[1].Value.ToString();
                string tablet = row.Cells[2].Value.ToString();
                string television = row.Cells[3].Value.ToString();
                string brand = row.Cells[4].Value.ToString();
                string price = row.Cells[5].Value.ToString();

                userPrice += double.Parse(price);

                if (console == "Yes")
                {
                    consoleTabControl.Enabled = true;
                    consoleBundleFourRadioButton.Checked = true;
                    consoleWarrantyFourRadioButton.Checked = true;
                }

                if (computer == "Yes")
                {
                    computerGroupGox.Enabled = true;
                    computerWarrantyFourRadioButton.Checked = true;
                }

                if (tablet == "Yes")
                {
                    tabletGroupBox.Enabled = true;
                    tabletWarrantyFourRadioButton.Checked = true;
                }

                if (television == "Yes")
                {
                    televisionGroupBox.Enabled = true;
                    televisionWarrantyFourRadioButton.Checked = true;
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //Adding Console Bundle price information to the userPrice variable so it has an accumulated overall price
            if (consoleBundleOneRadioButton.Checked)
            {
                userPrice += 30.00;
            }            
            else if (consoleBundleTwoRadioButton.Checked)
            {
                userPrice += 45.00;
            }
            else if (consoleBundleThreeRadioButton.Checked)
            {
                userPrice += 60.00;
            }
            
            //Adding Console Warranty price information to the userPrice variable so it has an accumulated overall price
            if (consoleWarrantyOneRadioButton.Checked)
            {
                userPrice += 30.00;
            }
            else if (consoleWarrantyTwoRadioButton.Checked)
            {
                userPrice += 45.00;
            }
            else if (consoleWarrantyThreeRadioButton.Checked)
            {
                userPrice += 60.00;
            }

            //Adding Computer Warranty price information to the userPrice variable so it has an accumulated overall price
            if (computerWarrantyOneRadioButton.Checked)
            {
                userPrice += 30.00;
            }
            else if (computerWarrantyTwoRadioButton.Checked)
            {
                userPrice += 45.00;
            }
            else if (computerWarrantyThreeRadioButton.Checked)
            {
                userPrice += 60.00;
            }
            
            //Adding Tablet Warranty price information to the userPrice variable so it has an accumulated overall price
            if (tabletWarrantyOneRadioButton.Checked)
            {
                userPrice += 30.00;
            }
            else if (tabletWarrantyTwoRadioButton.Checked)
            {
                userPrice += 45.00;
            }
            else if (tabletWarrantyThreeRadioButton.Checked)
            {
                userPrice += 60.00;
            }

            //Adding Television Warranty price information to the userPrice variable so it has an accumulated overall price
            if (televisionWarrantyOneRadioButton.Checked)
            {
                userPrice += 30.00;
            }
            else if (televisionWarrantyTwoRadioButton.Checked)
            {
                userPrice += 45.00;
            }
            else if (televisionWarrantyThreeRadioButton.Checked)
            {
                userPrice += 60.00;
            }


            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();

            //Go back to the Main Application since the user has requested to
            OrderScreenPartTwo orderScreenPartTwoForm = new OrderScreenPartTwo();
            orderScreenPartTwoForm.userPrice = userPrice;
            orderScreenPartTwoForm.userName = orderProperty;
            orderScreenPartTwoForm.Show();
        }
    }
}
