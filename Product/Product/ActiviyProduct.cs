using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class ActiviyProduct : IProduct
    {
        public void Save()
        {
            Console.WriteLine("activity save");
        }
        public void Book()
        {
            Console.WriteLine("activity book");
        }
        public string GetTypeOfProduct()
        {
            return "";
        }
    }
}
