using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Product
    {
        public class CacheDecorators
        {
            public void CheckForCache(ICache cacheType, IProduct prod)
            {

                ObjectCache cache = MemoryCache.Default;

                string key = prod.GetTypeOf();
                if (cache.Contains(key))
                {
                cacheType.GetFromCache(key,prod);
                }
                else
                {
                    cacheType.AddToCache(key,prod);
                    IRepository sqlService = new SqlRepository();
                    sqlService.Get(prod);
                }

            }
        }
    }
