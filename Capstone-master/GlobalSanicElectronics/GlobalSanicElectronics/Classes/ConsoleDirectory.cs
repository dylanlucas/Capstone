using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    //Variable to hold the information of the Console Directory table
    [Table(Name = "ConsoleDirectory")]
    public class ConsoleDirectory
    {
        [Column(IsPrimaryKey = true)]
        public int ConsoleID;               //Hold the consoleID (primary key) of the Console Information
        [Column]
        public string Brand;                //Hold the Brand name of the Console Information
        [Column]
        public string Storage;              //Hold the Storage information of the Console
        [Column]
        public string Price;                //Hold the Price information of the Console
        [Column]
        public string Console;              //Tell whether item is a console or not
    }
}
