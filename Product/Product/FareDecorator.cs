using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
   public class FareDecorator
    {
        private UpdateFare products;  //this is on which product to beapplied
        private ProductStrategy prodStrategy;//this is which strategy to be applied
        public void GetActualFare(IProduct prod)
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
            else if (product == typeof(ActivityProduct))
            {
                prodStrategy = new ActivityStrategy();
            }
            products = new UpdateFare(prodStrategy);
            products.ShowActualPrice(prod);

        }
    }
   
}

