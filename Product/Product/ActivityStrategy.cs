using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class ActivityStrategy:IProductStrategy
    {
        public double ProductFare(IProduct activity)
        {
            FileRepository.Instance.Add("In Activity Strategy function product fare function is called" + "Activity Product Fare is updated");
            return activity.Fare + 20;

        }
    }
}
