using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name = "TelevisionDirectory")]
    public class TelevisionDirectory
    {
        [Column(IsPrimaryKey = true)]
        public string TVID;
        [Column]
        public string Brand;
        [Column]
        public string Size;
        [Column]
        public bool LED;
        [Column]
        public bool Smart;
        [Column]
        public string Resolution;
        [Column]
        public string Color;
        [Column]
        public string Price;
        [Column]
        public string Television;
    }
}
