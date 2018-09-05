using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class CarProduct : IProduct
    {
        public void Save()
        {
            Console.WriteLine("car save");
        }
        public void Book()
        {
            Console.WriteLine("car book");
        }
        public string GetTypeOfProduct()
        {
            return "";
        }
    }
}
