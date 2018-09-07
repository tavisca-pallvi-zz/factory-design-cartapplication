using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class AirProduct : IProduct
    {
        public string airName;
        public int airId;
        public string itemname = "swift";
        public int itemid = 1;
        public bool isbooked = false;
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
            Console.WriteLine("air save");
        }
        public void Book()
        {
            Console.WriteLine("air book");

        }
        public string GetTypeOfProduct()
        {
            return "";
        }
    }
}
