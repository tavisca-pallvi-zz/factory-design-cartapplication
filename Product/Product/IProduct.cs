using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
  public  interface IProduct
    {
        string itemName
        {
            get;
            set;
        }
        int itemId
        {
            get;
            set;
        }
        bool isBooked
        {
            get;
            set;
        }
        double Fare
        {
            get;
            set;
        }
        string GetTypeOf();
       
    }
}
