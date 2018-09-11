using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
   public interface ICache
    {
        void AddToCache(string key, IProduct value);

        void GetFromCache(string prodType, IProduct prod);
    }
}
