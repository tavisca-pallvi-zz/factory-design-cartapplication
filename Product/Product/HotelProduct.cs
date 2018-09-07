using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class HotelProduct : IProduct
    {
        
        public string itemname = "NNOVATE";
        public int itemid = 1;
        public bool isbooked;
        public double fare=100;
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
                return isbooked;
            }
            set
            {

                isbooked = value;
            }
        }
        public double Fare
        {
            get
            {
                return fare;
            }
            set
            {

                fare = value;
            }
        }
        public string GetTypeOf()
        {
            return "HotelProduct";
        }

    }
}
