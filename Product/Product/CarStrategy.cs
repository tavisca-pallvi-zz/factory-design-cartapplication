using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class CarStrategy:IProductStrategy
    {
       public double ProductFare(IProduct car)
        {
            FileRepository.Instance.Add("Car Strategy function product fare is called"+"Car Product Fare is updated");
            return car.Fare+20;

        }

    }
}
