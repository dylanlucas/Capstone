using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name ="ComputerDirectory")]
    public class ComputerDirectory
    {
        [Column(IsPrimaryKey = true)]
        public int ComputerID;
        [Column]
        public string Brand;
        [Column]
        public string Size;
        [Column]
        public string Processor;
        [Column]
        public string Storage;
        [Column]
        public string RAM;
        [Column]
        public string Color;
        [Column]
        public string Price;
        [Column]
        public string Computer;
    }
}
