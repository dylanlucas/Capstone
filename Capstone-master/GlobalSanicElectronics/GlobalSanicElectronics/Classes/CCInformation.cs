using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name="CCInformation")]
    class CCInformation
    {
        [Column]
        public string CCNumber;
        [Column]
        public string CCName;
        [Column]
        public string Username;
        [Column(IsPrimaryKey = true)]
        public int CCID;
    }
}
