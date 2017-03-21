using GlobalSanicElectronics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Tests
{
    [TestClass]
    public class PasswordHashingTesting
    {
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
