using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
   public
        class HotelStrategy: ProductStrategy
    {
        
          public override double ProductFare(IProduct hotel)
            {
            FileRepository.Instance.Add("Hotel Strategy function product fare is called" + "Hotel Product Fare is updated");
            return hotel.Fare + 20;
           
            }

         

    }
}
