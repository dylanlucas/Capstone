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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        //Declare variable for Database
        System.Data.SqlClient.SqlConnection sqlConnectionLink =
            new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dylan\\Source\\Repos\\Capstone\\Capstone-master\\GlobalSanicElectronics\\GlobalSanicElectronics\\GSEDatabase.mdf;Integrated Security=True");

        public string cartProperty { get; set; }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(cartDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.cartDataGridView.SelectedRows)
                {
                    string cartID = row.Cells[0].Value.ToString();
                    string cartUsername = row.Cells[1].Value.ToString();
                    string cartBrand = row.Cells[2].Value.ToString();
                    string cartSize = row.Cells[3].Value.ToString();
                    string cartProcessor = row.Cells[4].Value.ToString();
                    string cartStorage = row.Cells[5].Value.ToString();
                    string cartRAM = row.Cells[6].Value.ToString();
                    string cartWifi = row.Cells[7].Value.ToString();
                    string cartSmart = row.Cells[8].Value.ToString();
                    string cartLED = row.Cells[9].Value.ToString();
                    string cartResolution = row.Cells[10].Value.ToString();
                    string cartColor = row.Cells[11].Value.ToString();
                    string cartPrice = row.Cells[12].Value.ToString();

                    cartDataGridView.Rows.RemoveAt(row.Index);

                    //Declare Variables
                    Int32 removeAndUpdateCart;

                    string remove = "DELETE FROM Cart WHERE CartID=" + cartID;
                    SqlCommand removeAndUpdateCommand = new SqlCommand(remove, sqlConnectionLink);
                    sqlConnectionLink.Open();
                    removeAndUpdateCart = Convert.ToInt32(removeAndUpdateCommand.ExecuteScalar());
                    sqlConnectionLink.Close();

                    MessageBox.Show("Item has been removed from your cart!");

                    cartDataGridView.Update();
                    cartTableAdapter.Update(gSEDatabaseDataSet.Cart);
                    cartDataGridView.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete from your cart!");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {            
            //Hide this form so the user can no longer see it as it is no longer needed
            this.Hide();
            this.Refresh();

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.MyProperty = cartProperty;
            mainApplicationForm.Show();
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

        private void Cart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSEDatabaseDataSet.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.gSEDatabaseDataSet.Cart);

            

            cartBindingSource.ResetBindings(false);

            this.cartTableAdapter.SearchCart(
                            this.gSEDatabaseDataSet.Cart, cartProperty);

            cartDataGridView.Visible = true;
        }

        private void cartBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void cartBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void cartBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void cartBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void cartBindingNavigatorSaveItem_Click_5(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }

        private void cartBindingNavigatorSaveItem_Click_6(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSEDatabaseDataSet);

        }
    }
}
