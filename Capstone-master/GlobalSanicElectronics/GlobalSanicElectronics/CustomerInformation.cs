using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name="CustomerInformation")]
    public class CustomerInformation
    {
        [Column(IsPrimaryKey = true)]
        public string Username;
        [Column]
        public string Password;
        [Column]
        public string Email;
        [Column]
        public string DOB;
        [Column]
        public string Address;
        [Column]
        public string City;
        [Column]
        public string State;
        [Column]
        public string Zip;        
    }   
}
