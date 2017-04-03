using GlobalSanicElectronics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Tests
{
    [TestClass]
    public class PasswordHashingTesting
    {
        //Test to make sure that the password is being hashed and salted correctly
        [TestMethod]
        public void TestingPasswordHashingAndSalting_Correctly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Password = "ABCdef123$%^";
            bool expected = true;

            //Act
            bool result = PasswordOperations.AccountPasswordHashing(newCustomer.Password);

            //Assert
            Assert.AreEqual(expected, result);
        }

        //Test to make sure that the logic behind a null password is incorrect, is correct
        [TestMethod]
        public void TestingPasswordHashingAndSalting_Incorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Password = "";
            bool notExpected = true;

            //Act
            bool result = PasswordOperations.AccountPasswordHashing(newCustomer.Password);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }
    }
}
