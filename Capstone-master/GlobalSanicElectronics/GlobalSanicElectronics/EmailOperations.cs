using System.Net;
using System.Net.Mail;


namespace GlobalSanicElectronics
{
    class EmailOperations
    {
        public static void UserCreatedEmail(string email, string username, string DOB, string address, string city, string state, string zip)
        {
            //Way to send user an email with all account information and confirm that there account is created.
            var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toAddress = new MailAddress(email, username);
            const string fromPassword = "GSEPassword";
            const string subject = "Thank you for joining Global Sanic Electronics!";
            string body = "Hello " + username + " thank you for joining Global Sanic Electronics." + "\n\n" +
                "To ensure all your information is correct, this is what you entered upon account creation. If any of this information needs to be updated, please do not hesitate to email us back" + "\n\n" +
                "Email = " + email + "\n" +
                "Date of Birth = " + DOB + "\n" +
                "Street Address = " + address + "\n" +
                "City = " + city + "\n" +
                "State = " + state + "\n" +
                "Zip = " + zip + "\n\n" +
                "Thank you once again for joining Global Sanic Electronics! We hope you enjoy your stay!";

            //Area to establish a connection with the smtpclient and put the host and port number down
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            //Area to actually send the message out to the user
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
