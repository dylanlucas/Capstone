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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent(); 
        }


        public string cartFormUsername { get; set; }        

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(cartDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.cartDataGridView.SelectedRows)
                {                    
                    string cartID = row.Cells[16].Value.ToString();

                    cartDataGridView.Rows.RemoveAt(row.Index);

                    //Declare Variables
                    Int32 removeAndUpdateCart;

                    string remove = "DELETE FROM Cart WHERE CartID= " + cartID;
                    SqlCommand removeAndUpdateCommand = new SqlCommand(remove, DatabaseOperations.sqlConnectionLink);
                    DatabaseOperations.sqlConnectionLink.Open();
                    removeAndUpdateCart = Convert.ToInt32(removeAndUpdateCommand.ExecuteScalar());
                    DatabaseOperations.sqlConnectionLink.Close();

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

            //Go back to the Main Application since the user has requested to
            MainApplication mainApplicationForm = new MainApplication();
            mainApplicationForm.mainApplicationUsername = cartFormUsername;
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
            var select = "SELECT * FROM Cart WHERE Username= '" + cartFormUsername + "'";            
            var dataAdapter = new SqlDataAdapter(select, DatabaseOperations.sqlConnectionLink);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            cartDataGridView.ReadOnly = true;
            cartDataGridView.DataSource = ds.Tables[0];
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
    }
}
