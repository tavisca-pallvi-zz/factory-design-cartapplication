using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
   public interface IRepository
    {
        void AddToFile(IProduct product,string msg);
       
    }
}
