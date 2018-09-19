using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class AirProduct : IProduct
    {
        public string itemname = "swift";
        public int itemid = 1;
        public bool isbooked = false;
        public double fare = 40;
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
            return "AirProduct";
        }

    }
}
