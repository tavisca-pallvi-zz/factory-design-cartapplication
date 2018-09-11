using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class AirStrategy:IProductStrategy
    {
        public double ProductFare(IProduct car)
        {
            FileRepository.Instance.Add("In Air Strategy function product fare function is called" + "Air Product Fare is updated");
            return car.Fare + 20;
            
        }
    }
}
