﻿using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    static public class DatabaseOperationsUser
    {
        //Method to create a user and store it into the database
        public static void CreateUser(CustomerInformation customer)
        {
            using (System.Data.SqlClient.SqlCommand createUserCommand = new System.Data.SqlClient.SqlCommand())
            {
                try
                {
                    createUserCommand.CommandText = ("INSERT into CustomerInformation (Username, Password, Email, DOB, Address, City, State, Zip) VALUES " +
                    "(@Username, @Password, @Email, @DOB, @Address, @City, @State, @Zip)");
                    createUserCommand.Parameters.AddWithValue("@Username", customer.Username);
                    createUserCommand.Parameters.AddWithValue("@Password", customer.Password);
                    createUserCommand.Parameters.AddWithValue("@Email", customer.Email);
                    createUserCommand.Parameters.AddWithValue("@DOB", customer.DOB);
                    createUserCommand.Parameters.AddWithValue("@Address", customer.Address);
                    createUserCommand.Parameters.AddWithValue("@City", customer.City);
                    createUserCommand.Parameters.AddWithValue("@State", customer.State);
                    createUserCommand.Parameters.AddWithValue("@Zip", customer.Zip);
                    createUserCommand.Connection = DatabaseOperations.sqlConnectionLink;

                    DatabaseOperations.sqlConnectionLink.Open();
                    createUserCommand.ExecuteNonQuery();
                    DatabaseOperations.sqlConnectionLink.Close();
                }                
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Method to select user and make sure that it is correlating with the username and password in the same area
        public static bool SelectUser(CustomerInformation customer, TextBox password)
        {
            using (System.Data.SqlClient.SqlCommand searchUserCommand = new System.Data.SqlClient.SqlCommand())
            {
                searchUserCommand.CommandText = ("SELECT * From CustomerInformation WHERE Username Like @Username AND Password = @Password;");
                searchUserCommand.Parameters.AddWithValue("@Username", customer.Username);
                searchUserCommand.Parameters.AddWithValue("@Password", PasswordOperations.AccountPasswordHashing(password.Text));
                searchUserCommand.Connection = DatabaseOperations.sqlConnectionLink;
                DatabaseOperations.sqlConnectionLink.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(searchUserCommand);
                da.Fill(ds);
                DatabaseOperations.sqlConnectionLink.Close();

                bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                return loginSuccessful;
            }
        }
    }
}
