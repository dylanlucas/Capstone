using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlobalSanicElectronics;
using System.Windows.Forms;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void NewUsername()
        {
            try
            {
                CustomerInformation newCustomer = new CustomerInformation();

                string username = "THISISANEWUSERNAME";
                string Password = "Testing123$%^";
                string email = "dylan.l.cosmos@gmail.com";
                string dob = "01/01/1990";
                string address = "Address";
                string city = "City";
                string state = "ST";
                string zip = "90210";
                
                newCustomer.Username = username;

                //All these fields are correct and should work.
                newCustomer.Password = Password;
                newCustomer.Email = email;
                newCustomer.DOB = dob;
                newCustomer.Address = address;
                newCustomer.City = city;
                newCustomer.State = state;
                newCustomer.Zip = zip;

                DatabaseOperationsUser.CreateUser(newCustomer);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
