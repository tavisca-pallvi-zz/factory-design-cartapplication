using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class ProductService
    {
        string msg = "";
        FileRepository fileob = FileRepository.Instance;
        //decorator vala pehle activity me hogya

       
        public void Save(IProduct prod,IRepository storageType)
        {
            fileob.Add("save method called");
            prod.isBooked = false;
            storageType.Add(prod, prod.Fare);
            Console.WriteLine(prod.itemName);
            Console.WriteLine("product Fare is");
           // Console.WriteLine(prodFare);
            Console.WriteLine(prod.isBooked);
            
        }
        public void Book(IProduct prod, IRepository storageType)
        {

            fileob.Add("book method called");
            prod.isBooked = true;

            storageType.Add(prod, prod.Fare);
            Console.WriteLine(prod.itemName);
            Console.WriteLine("product Fare is");
          //  Console.WriteLine(prodFare);
            fileob.Add(msg);
            
            Console.WriteLine(prod.isBooked);
          //  Console.WriteLine("car book");

        }

    }
}
