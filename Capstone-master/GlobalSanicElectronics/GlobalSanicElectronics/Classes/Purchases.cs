using System.Data.Linq.Mapping;

namespace GlobalSanicElectronics
{
    //Variable to hold the information of the Purchases table
    [Table(Name = "Purchases")]
    public class Purchases
    {
        [Column]
        public string Username;                 //Hold the username of the user who made the purchase
        [Column]
        public int OrderNumber;                 //Hold the OrderNumber of the user's purchase information
        [Column]
        public string Computer;                 //Tell whether the item the user purchased is a computer
        [Column]
        public string Console;                  //Tell whether the item the user purchased is a console
        [Column]
        public string Television;               //Tell whether the item the user purchased is a television
        [Column]
        public string Tablet;                   //Tell whether the item the user purchased is a tablet
        [Column]
        public string Price;                    //Hold the price information of what the user purchased (total price)
        [Column]
        public string Stages;                   //Hold stage information of delivery and shipping for the purchase order
        [Column(IsPrimaryKey = true)]
        public int PurchaseNumber;              //(Primary Key)Hold the PurhcaseNumber of the Purhcase Table
    }
}
