using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class CreateStrategy
    {

        IProductStrategy prodStrategy;
        public IProductStrategy GetProductStrategy(IProduct prod)
        {
      
            Type product = prod.GetType();
            if (product == typeof(CarProduct))
            {
                prodStrategy = new CarStrategy();
            }
            else if (product == typeof(HotelProduct))
            {
                prodStrategy = new HotelStrategy();
            }
            else if (product == typeof(AirProduct))
            {
                prodStrategy = new AirStrategy();
            }

            return prodStrategy;

        }
    }
   
}

