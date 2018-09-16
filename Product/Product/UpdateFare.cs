using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class UpdateFare
    {
        private ProductStrategy prod;

        public UpdateFare(ProductStrategy prod)
        {
            this.prod = prod;

        }
        public void ShowActualPrice(IProduct product)
        {
            prod.ProductFare(product);
        }


    }
}
