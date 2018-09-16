using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class CreateType
    {
        Object prod;
        public  Object GetProduct(string itemType)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name ==itemType );
            return (Object)Activator.CreateInstance(productType);

        
        }
    }
}
