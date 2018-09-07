using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class HotelProduct : IProduct
    {
        public string itemname = "swift";
        public int itemid = 1;
        public bool isbooked;
        public string itemName
        {
            get
            {
                return itemname;
            }
            set
            {
                itemname = value;
            }
        }
        public int itemId
        {
            get
            {
                return itemid;
            }
            set
            {
                itemid = value;

            }
        }
        public bool isBooked
        {
            get
            {
                return isBooked;
            }
            set
            {

                isBooked = value;
            }
        }
        public void Save()
        {
            Console.WriteLine("hotel save");

        }
        public void Book()
        {
            Console.WriteLine("hotel save");
        }
        public string GetTypeOfProduct()
        {
            return "";
        }
    }
}
