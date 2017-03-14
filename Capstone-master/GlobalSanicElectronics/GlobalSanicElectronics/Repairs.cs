using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name = "Repairs")]
    class Repairs
    {
        [Column]
        public int OrderNumber;
        [Column]
        public string Computer;
        [Column]
        public string RepairStatus;
        [Column]
        public string Username;
        [Column]
        public string Console;
        [Column]
        public string Tablet;
        [Column]
        public string Television;
        [Column(IsPrimaryKey = true)]
        public int RepairID;
    }
}
