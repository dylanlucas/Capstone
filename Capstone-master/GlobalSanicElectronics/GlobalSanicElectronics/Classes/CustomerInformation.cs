using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    //Variable to hold the information of the Customer Information table
    [Table(Name="CustomerInformation")]
    public class CustomerInformation
    {
        [Column(IsPrimaryKey = true)]
        public string Username;                     //Hold the user's username information
        [Column]
        public string Password;                     //Hold the password information of the user
        [Column]
        public string Email;                        //Hold the email information of the user
        [Column]
        public string DOB;                          //Hold the Date of Birth information of the user
        [Column]
        public string Address;                      //Hold the address information of the user
        [Column]
        public string City;                         //Hold the city informatino of the user
        [Column]
        public string State;                        //Hold the state information of the user
        [Column]
        public string Zip;                          //Hold the zip information of the user
    }   
}
