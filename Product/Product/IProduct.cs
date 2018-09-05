using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
  public  interface IProduct
    {
        void Save();
        void Book();
        string GetTypeOfProduct();
    }
}
