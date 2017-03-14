using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name ="Cart")]
    public class Cart
    {
        [Column]
        public string Username;
        [Column]
        public string Computer;
        [Column]
        public string Console;
        [Column]
        public string Tablet;
        [Column]
        public string Television;
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
        public string Wifi;
        [Column]
        public string Smart;
        [Column]
        public string LED;
        [Column]
        public string Resolution;
        [Column]
        public string Color;
        [Column]
        public string Price;
        [Column(IsPrimaryKey = true)]
        public int CartID;
    }
}
