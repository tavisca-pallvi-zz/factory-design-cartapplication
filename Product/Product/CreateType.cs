using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class CreateType
    {
        IProduct prod;
        public  IProduct GetProduct(string itemType)
        {
            if(String.Compare(itemType,"CarProduct")==0)
            {
                prod = new CarProduct();
            }
            else if (String.Compare(itemType, "Hotel") == 0)
            {
                prod = new HotelProduct();
            }
            else if (String.Compare(itemType, "Air") == 0)
            {
                prod = new AirProduct();
            }
            else if (String.Compare(itemType, "Activity") == 0)
            {
                prod = new ActiviyProduct();
            }

            return prod;
        }
    }
}
