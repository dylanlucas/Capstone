using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name = "TabletDirectory")]
    public class TabletDirectory
    {
        [Column(IsPrimaryKey = true)]
        public int TabletID;
        [Column]
        public string Brand;
        [Column]
        public string Size;
        [Column]
        public string Storage;
        [Column]
        public string Processor;
        [Column]
        public string Wifi;
        [Column]
        public string Color;
        [Column]
        public string Price;
        [Column]
        public string Tablet;
    }
}
