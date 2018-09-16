using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
  public abstract class ProductStrategy
    {

        //private ProductStrategy prodObj;
        public ProductStrategy()
        {
            
        }
        public abstract double ProductFare(IProduct prod);//becaue every aclss has its own implementation
        
    }
}
