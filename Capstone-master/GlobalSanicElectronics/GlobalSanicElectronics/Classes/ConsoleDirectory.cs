using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name = "ConsoleDirectory")]
    public class ConsoleDirectory
    {
        [Column(IsPrimaryKey = true)]
        public int ConsoleID;
        [Column]
        public string Brand;
        [Column]
        public string Storage;
        [Column]
        public string Price;
        [Column]
        public string Console;
    }
}
