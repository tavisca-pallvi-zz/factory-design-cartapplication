using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class AirProduct : IProduct
    {
        public void Save()
        {
            Console.WriteLine("air save");
        }
        public void Book()
        {
            Console.WriteLine("air book");

        }
        public string GetTypeOfProduct()
        {
            return "";
        }
    }
}
