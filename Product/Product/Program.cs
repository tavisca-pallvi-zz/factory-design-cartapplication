using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateType createType = new CreateType();
            string itemType = Console.ReadLine();

            IProduct prod = createType.GetProduct(itemType);
           
            try
            {

                string typeOf = prod.GetTypeOfProduct();
                prod.Save();
                prod.Book();
            }
            catch (Exception ob)
            {
                Console.WriteLine("not created type");

            }
            

            Console.ReadKey();
        }
    }
}
