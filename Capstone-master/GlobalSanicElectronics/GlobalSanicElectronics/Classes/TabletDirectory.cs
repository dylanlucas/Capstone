using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    //Variable to hold the information of the Tablet Directory table
    [Table(Name = "TabletDirectory")]
    public class TabletDirectory
    {
        [Column(IsPrimaryKey = true)]
        public int TabletID;                        //(Primary Key)Hold the Tablet Id of the Tablet table
        [Column]
        public string Brand;                        //Hold the Brand information of the Tablet
        [Column]
        public string Size;                         //Hold the Size information of the Tablet
        [Column]
        public string Storage;                      //Hold the Storage information of the Tablet
        [Column]
        public string Processor;                    //Hold the Processor information of the Tablet
        [Column]
        public string Wifi;                         //Tell whether the Tablet has Wifi or not and hold the information
        [Column]
        public string Color;                        //Tell the color information of the Tablet
        [Column]
        public string Price;                        //Hold the price information of the Tablet
        [Column]
        public string Tablet;                       //Tell whether the item is a Tablet or not
    }
}
