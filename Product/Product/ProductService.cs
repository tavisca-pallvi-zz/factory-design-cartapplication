using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class ProductService
    {
        string msg = "";

        FileRepository fileob = FileRepository.Instance;

        public void Save(IProduct prod,double prodFare)
        {
            fileob.Add("save method called");
            prod.isBooked = false;
          
            Console.WriteLine(prod.itemName);
            Console.WriteLine("product Fare is");
            Console.WriteLine(prodFare);
            Console.WriteLine(prod.isBooked);
            
        }
        public void Book(IProduct prod, double prodFare)
        {

            fileob.Add("book method called");
            prod.isBooked = true;
            Console.WriteLine(prod.itemName);
            Console.WriteLine("product Fare is");
            Console.WriteLine(prodFare);
            fileob.Add(msg);
            
            Console.WriteLine(prod.isBooked);
          //  Console.WriteLine("car book");

        }

    }
}
