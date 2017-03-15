using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name = "Purchases")]
    public class Purchases
    {
        [Column]
        public string Username;
        [Column]
        public int OrderNumber;
        [Column]
        public string Computer;
        [Column]
        public string Console;
        [Column]
        public string Television;
        [Column]
        public string Tablet;
        [Column]
        public string Price;
        [Column]
        public string Stages;
        [Column(IsPrimaryKey = true)]
        public int PurchaseNumber;
    }
}
