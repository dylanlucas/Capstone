using GlobalSanicElectronics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class AccountCreationUnitTesting
    {
        [TestMethod]
        public void TestingUsernameCorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Username = "TestingUsernameCorrectly";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.UsernameValidation(newCustomer.Username);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestingUsernameIncorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Username = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.UsernameValidation(newCustomer.Username);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void TestingEmailCorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Email = "testingemail@address.com";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.EmailValidation(newCustomer.Email);


            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestingEmailIncorrectly_NoEmail()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Email = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.EmailValidation(newCustomer.Email);


            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void TestingEmailIncorrectly_NoDomain()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Email = "dylan";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.EmailValidation(newCustomer.Email);


            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void BirthValidateCorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.DOB = "01/01/1990";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.BirthValidation(newCustomer.DOB);


            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BirthValidateIncorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Email = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.BirthValidation(newCustomer.DOB);


            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void AddressValidationCorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Address = "Address";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.AddressValidation(newCustomer.Address);


            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddressValidationIncorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.DOB = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.AddressValidation(newCustomer.Address);


            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void CityValidationCorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.City = "City";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.CityValidation(newCustomer.City);


            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CityValidationIncorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.City = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.CityValidation(newCustomer.City);


            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void StateValidationCorrectly()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.State = "ST";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.StateValidation(newCustomer.State);


            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StateValidationIncorrectly_MoreThan2Characters()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.State = "STA";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.StateValidation(newCustomer.State);


            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void StateValidationIncorrectly_LessThan2Characters()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.State = "S";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.StateValidation(newCustomer.State);


            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void TestingShippingStateIncorrectly_ContainsNumbers()
        {
            //Arrange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.State = "S1";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.StateValidation(existingCustomer.State);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void StateValidationIncorrectly_Null()
        {
            //Arrange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.State = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.StateValidation(newCustomer.State);


            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void ZipValidationCorrectly()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Zip = "90210";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.ZipValidation(newCustomer.Zip);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ZipValidationIncorrectly_NotJustNumbers()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Zip = "9ABC0";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.ZipValidation(newCustomer.Zip);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void ZipValidationIncorrectly_MoreThan5Numbers()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Zip = "1234567890";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.ZipValidation(newCustomer.Zip);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void ZipValidationIncorrectly_LessThan5Numbers()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Zip = "910";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.ZipValidation(newCustomer.Zip);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void ZipValidationIncorrectly_Null()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Zip = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.ZipValidation(newCustomer.Zip);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void PasswordValidationCorrectly()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Password = "ABCdef123$%^";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.PasswordValidation(newCustomer.Password);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PasswordValidationIncorrectly_Null()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Password = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.PasswordValidation(newCustomer.Password);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void PasswordValidationIncorrectly_NotContainingLowerCase()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Password = "ABC123$%^";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.PasswordValidation(newCustomer.Password);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void PasswordValidationIncorrectly_NotContainingUpperCase()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Password = "def123$%^";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.PasswordValidation(newCustomer.Password);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void PasswordValidationIncorrectly_NotProperLength()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Password = "Ab1@";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.PasswordValidation(newCustomer.Password);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void PasswordValidationIncorrectly_NotCotainingNumber()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Password = "ABCdef$%^";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.PasswordValidation(newCustomer.Password);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void PasswordValidationIncorrectly_NotContainingSpecialCharacter()
        {
            //Arange
            CustomerInformation newCustomer = new CustomerInformation();
            newCustomer.Password = "ABCdef123";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.PasswordValidation(newCustomer.Password);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }
    }
}
