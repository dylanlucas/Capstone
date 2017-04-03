using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    [Table(Name ="Cart")]
    public class Cart
    {
        //Variables to hold information related to the Cart Table
        [Column]
        public string Username;             //Hold username of the user
        [Column]
        public string ComputerID;           //Hold the ComputerID if the user has selected a computer to add to their cart
        [Column]
        public string ConsoleID;            //Hold the ConsoleID if the user has selected a console to add to their cart
        [Column]
        public string TabletID;             //Hold the TabletID if the user has selected a tablet to add to their cart
        [Column]
        public string TelevisionID;         //Hold the TelevisionID if the user has selected a television to add to their cart
        [Column]
        public string Brand;                //Hold the Brand name of the item that the user has selected to add to their cart
        [Column]
        public string Size;                 //Hold the size of the item that the user has selected to add to their cart
        [Column]
        public string Processor;            //Hold the processor information of the item that the user has selected to add to their cart
        [Column]
        public string Storage;              //Hold the storage information of the item that the user has selected to add to their cart
        [Column]
        public string RAM;                  //Hold the RAM information of the item that the user has selected to add to their cart
        [Column]
        public string Wifi;                 //Tell whether the item has Wifi or not that the user has selected to add to their cart
        [Column]
        public string Smart;                //Tell whether the item has Smart technology or not that the user has selected to add to their cart
        [Column]
        public string LED;                  //Tell whether the item is an LED device or not that the user has selected to add to their cart
        [Column]
        public string Resolution;           //Tell the resolution size of the item that the user has selected to add to their cart
        [Column]
        public string Color;                //Tell the color of the item that the user has selected to add to their cart
        [Column]
        public string Price;                //Tell the price of the item that the user has selected to add to their cart
        [Column(IsPrimaryKey = true)]
        public int CartID;                  //Tell the cartID of the item (primary key) that the user has selected to add to their cart

        public List<ConsoleDirectory> Consoles = new List<ConsoleDirectory>();                  //Make a list to hold Console Information
        public List<ComputerDirectory> Computers = new List<ComputerDirectory>();               //Make a list to hold the Computer Information
        public List<TabletDirectory> Tablets = new List<TabletDirectory>();                     //Make a list to hold the Tablet Information
        public List<TelevisionDirectory> Televisions = new List<TelevisionDirectory>();         //Make a list to hold the Television Information
    }
}
