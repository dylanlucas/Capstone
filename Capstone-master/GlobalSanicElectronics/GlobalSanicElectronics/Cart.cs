using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name ="Cart")]
    public class Cart
    {
        [Column]
        public string Username;
        [Column]
        public string ComputerID;
        [Column]
        public string ConsoleID;
        [Column]
        public string TabletID;
        [Column]
        public string TelevisionID;
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

        public List<ConsoleDirectory> Consoles = new List<ConsoleDirectory>();
        public List<ComputerDirectory> Computers = new List<ComputerDirectory>();
        public List<TabletDirectory> Tablets = new List<TabletDirectory>();
        public List<TelevisionDirectory> Televisions = new List<TelevisionDirectory>();
    }
}
