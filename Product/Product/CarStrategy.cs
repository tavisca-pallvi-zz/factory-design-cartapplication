using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class CarStrategy : ProductStrategy
    {
        public override double ProductFare(IProduct prod)
        {
            FileRepository.Instance.Add("car strategy function product fare is called" + "car product fare is updated");
            return prod.Fare + 20;

        }

    }
}
