using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name = "Refunds")]
    class Refunds
    {
        [Column]
        public int RefundNumber;
        [Column]
        public string Computer;
        [Column]
        public string RefundStatus;
        [Column]
        public string Console;
        [Column]
        public string Username;
        [Column]
        public string Tablet;
        [Column]
        public string Television;
        [Column(IsPrimaryKey = true)]
        public int RefundID;
    }
}
