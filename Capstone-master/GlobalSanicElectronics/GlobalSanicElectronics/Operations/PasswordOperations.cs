using System;
using System.Text;


namespace GlobalSanicElectronics
{
    class PasswordOperations
    {
        //Method to hash and salt the password information
        public static string AccountPasswordHashing(string password)
        {
            string salt = "WquZ012C";

            var bytes = new UTF8Encoding().GetBytes(salt + password);
            byte[] hashBytes;

            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }

            string passHash = Convert.ToBase64String(hashBytes);

            return passHash;
        }
    }
}
