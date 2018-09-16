using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class UserChoice
    {

        CreateType createType = new CreateType();
        Object prod = null;
      
        

        public Object GetChoice()
        {
            Console.WriteLine("Enter the type  you want :");
            string itemType = Console.ReadLine();

            try
            {
               
                prod = createType.GetProduct(itemType);

            }
            catch (Exception ob)
            {
                Console.WriteLine("not created type");
            }
            return prod;

        }
    }
}
