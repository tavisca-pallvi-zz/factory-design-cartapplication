using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace Product
{
    public class MemoryCachess:ICache
    {

        ObjectCache cache = MemoryCache.Default;
     
      
        public void GetFromCache(string prodType, IProduct prod)
        {
           
            
             prod= (IProduct)cache.Get(prodType);
            Console.WriteLine(prod.itemId);
            Console.WriteLine(prod.itemName);
            Console.WriteLine(prod.isBooked);
            Console.WriteLine(prod.Fare);

        }
            public void AddToCache(string prodType,IProduct prod)
        {
            if (cache.Get(prodType) == null)
            {
                CacheItemPolicy cacheitempolicy = new CacheItemPolicy();
                cacheitempolicy.AbsoluteExpiration = DateTime.Now.AddHours(1.0);
                cache.Add(prodType, prod, cacheitempolicy);

            }
        }
    }
}
    

