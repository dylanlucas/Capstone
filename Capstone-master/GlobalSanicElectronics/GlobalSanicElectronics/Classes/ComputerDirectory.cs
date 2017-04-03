using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name ="ComputerDirectory")]
    public class ComputerDirectory
    {
        //Variable to hold the information of the Computer Directory table
        [Column(IsPrimaryKey = true)]
        public int ComputerID;                  //Hold the information of the ComputerID (primary key)
        [Column]
        public string Brand;                    //Hold the Brand name of the Computer
        [Column]
        public string Size;                     //Hold the size, dimensions, of the computer
        [Column]
        public string Processor;                //Hold the processor information of the computer
        [Column]
        public string Storage;                  //Hold the storage information of the computer
        [Column]
        public string RAM;                      //Hold the RAM information of the computer
        [Column]
        public string Color;                    //Hold the color information of the computer
        [Column]
        public string Price;                    //Hold the price information of the computer
        [Column]
        public string Computer;                 //Hold information if the item is a computer or not
    }
}
