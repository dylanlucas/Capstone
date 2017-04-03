using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    //Variable to hold the information of the Television Directory table
    [Table(Name = "TelevisionDirectory")]
    public class TelevisionDirectory
    {
        [Column(IsPrimaryKey = true)]
        public string TVID;                         //(Primary Key) Hold the Television ID of the Television
        [Column]
        public string Brand;                        //Hold the brand name of the Television
        [Column]
        public string Size;                         //Hold the size information of the Television
        [Column]
        public bool LED;                            //Tell whether the television has LED or not and hold that information
        [Column]
        public bool Smart;                          //Tell whether the television is a SMART tv or not and hold that information
        [Column]
        public string Resolution;                   //Hold the resolution information of the Television
        [Column]
        public string Color;                        //Hold the color information of the Television
        [Column]
        public string Price;                        //Hold the price information of the Television
        [Column]
        public string Television;                   //Tell whether the item is a Television or not and hold the information
    }
}
