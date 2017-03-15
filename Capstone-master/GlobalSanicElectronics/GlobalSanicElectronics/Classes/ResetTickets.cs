using System.Data.Linq.Mapping;
using System;

namespace GlobalSanicElectronics
{
    [Table(Name = "ResetTickets")]
    class ResetTickets
    {
        [Column(IsPrimaryKey = true)]
        public int Id;
        [Column]
        public string Username;
        [Column]
        public string tokenHash;
        [Column]
        public DateTime datetime; 
    }
}
