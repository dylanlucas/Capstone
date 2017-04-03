using GlobalSanicElectronics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class OrderScreenUnitTesting
    {
        //Test to make sure that the Address entered is in correct format
        [TestMethod]
        public void TestingShippingAddressCorrectly()
        {
            //Arrange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.Address = "Address";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.AddressValidation(existingCustomer.Address);

            //Assert
            Assert.AreEqual(expected, result);
        }

        //Test to make sure the logic behind an address being null is incorrect, is correct
        [TestMethod]
        public void TestingShippingAddressIncorrectly()
        {
            //Arrange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.Address = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.AddressValidation(existingCustomer.Address);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the city entered is in correct format
        [TestMethod]
        public void TestingShippingCityCorrectly()
        {
            //Arrange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.City = "City";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.CityValidation(existingCustomer.City);

            //Assert
            Assert.AreEqual(expected, result);
        }

        //Test to make sure that the logic behind a city being null is incorrect, is correct
        [TestMethod]
        public void TestingShippingCityIncorrectly()
        {
            //Arrange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.City = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.CityValidation(existingCustomer.City);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the state entered is in correct format
        [TestMethod]
        public void TestingShippingStateCorrectly()
        {
            //Arrange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.State = "ST";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.StateValidation(existingCustomer.State);

            //Assert
            Assert.AreEqual(expected, result);
        }

        //Test to make sure that the logic behind a state being more than 2 characters is incorrect, is correct
        [TestMethod]
        public void TestingShippingStateIncorrectly_MoreThan2Characters()
        {
            //Arrange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.State = "STA";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.StateValidation(existingCustomer.State);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the logic behind a state being less than 2 characters is incorrect, is correct
        [TestMethod]
        public void TestingShippingStateIncorrectly_LessThan2Characters()
        {
            //Arrange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.State = "S";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.StateValidation(existingCustomer.State);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the logic behind a state containing numbers is incorrect, is correct
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

        //Test to make sure that the logic behind a state being null is incorrect, is correct
        [TestMethod]
        public void TestingShippingStateIncorrectly_Null()
        {
            //Arrange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.State = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.StateValidation(existingCustomer.State);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the zip entered is in correct format
        [TestMethod]
        public void ZipValidationCorrectly()
        {
            //Arange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.Zip = "90210";
            bool expected = true;

            //Act
            bool result = AccountCreationVerification.ZipValidation(existingCustomer.Zip);

            //Assert
            Assert.AreEqual(expected, result);
        }

        //Test to make sure that the logic of a zip not being just numbers is incorrect, is correct
        [TestMethod]
        public void ZipValidationIncorrectly_NotJustNumbers()
        {
            //Arange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.Zip = "9ABC0";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.ZipValidation(existingCustomer.Zip);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the logic of a zip not being more than 5 numbers is incorrect, is correct
        [TestMethod]
        public void ZipValidationIncorrectly_MoreThan5Numbers()
        {
            //Arange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.Zip = "1234567890";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.ZipValidation(existingCustomer.Zip);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the logic of a zip not being less than 5 numbers is incorrect, is correct
        [TestMethod]
        public void ZipValidationIncorrectly_LessThan5Numbers()
        {
            //Arange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.Zip = "910";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.ZipValidation(existingCustomer.Zip);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the logic of a zip being null is incorrect, is correct
        [TestMethod]
        public void ZipValidationIncorrectly_Null()
        {
            //Arange
            CustomerInformation existingCustomer = new CustomerInformation();
            existingCustomer.Zip = "";
            bool notExpected = true;

            //Act
            bool result = AccountCreationVerification.ZipValidation(existingCustomer.Zip);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the card name is in correct format
        [TestMethod]
        public void CardNameValidationCorrectly()
        {
            //Arrange
            string name = "TestingName";
            bool expected = true;

            //Act
            bool result = GeneralVerification.ConfirmName(name);

            //Assert
            Assert.AreEqual(expected, result);
        }

        //Test to make sure that the logic behind a card name being null is incorrect, is correct
        [TestMethod]
        public void CardNameValidationIncorrectly_Null()
        {
            //Arrange
            string name = "";
            bool notExpected = true;

            //Act
            bool result = GeneralVerification.ConfirmName(name);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the logic behind a card name containing numbers is incorrect, is correct
        [TestMethod]
        public void CardNameValidationIncorrectly_ContainsNumbers()
        {
            //Arrange
            string name = "12345";
            bool notExpected = true;

            //Act
            bool result = GeneralVerification.ConfirmName(name);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the logic behind a card number is in correct format
        [TestMethod]
        public void CardNumberValidationCorrectly()
        {
            //Arrange
            string number = "1234123412341234";
            bool expected = true;

            //Act
            bool result = GeneralVerification.ConfirmNumber(number);

            //Assert
            Assert.AreEqual(expected, result);
        }

        //Test to make sure that the logic behind a card number containing letters is incorrect, is correct
        [TestMethod]
        public void CardNumberValidationIncorrectly_ContainsLetters()
        {
            //Arrange
            string number = "1234ABCD1234ABCD";
            bool notExpected = true;

            //Act
            bool result = GeneralVerification.ConfirmNumber(number);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the card number that is more than 16 digits is incorrect, is correct
        [TestMethod]
        public void CardNumberValidationIncorrectly_LongerThan16Digits()
        {
            //Arrange
            string number = "12341234123412341234";
            bool notExpected = true;

            //Act
            bool result = GeneralVerification.ConfirmNumber(number);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the card number that is less than 16 digits is incorrect, is correct
        [TestMethod]
        public void CardNumberValidationIncorrectly_ShorterThan16Digits()
        {
            //Arrange
            string number = "1234";
            bool notExpected = true;

            //Act
            bool result = GeneralVerification.ConfirmNumber(number);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the card number is null is incorrect, is correct
        [TestMethod]
        public void CardNumberValidationIncorrectly_Null()
        {
            //Arrange
            string number = "";
            bool notExpected = true;

            //Act
            bool result = GeneralVerification.ConfirmNumber(number);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the Card expiration date is in correct format
        [TestMethod]
        public void CardExpirationDateCorrectly()
        {
            //Arrange
            string month = "05";
            string year = "2017";
            bool expected = true;

            //Act
            bool result = GeneralVerification.ConfirmExpirationDate(month, year);

            //Assert
            Assert.AreEqual(expected, result);
        }

        //Test to make sure the logic that the card expiration date being null is incorrect, is correct
        [TestMethod]
        public void CardExpirationDateIncorrectly_Null()
        {
            //Arrange
            string month = "";
            string year = "";
            bool notExpected = true;

            //Act
            bool result = GeneralVerification.ConfirmExpirationDate(month, year);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }

        //Test to make sure that the logic behind a card expiration date being less than now is incorrect, is correct
        [TestMethod]
        public void CardExpirationDateIncorrectly_LessThanNowWithDate()
        {
            //Arrange
            string month = "01";
            string year = "2017";
            bool notExpected = true;

            //Act
            bool result = GeneralVerification.ConfirmExpirationDate(month, year);

            //Assert
            Assert.AreNotEqual(notExpected, result);
        }
    }
}
