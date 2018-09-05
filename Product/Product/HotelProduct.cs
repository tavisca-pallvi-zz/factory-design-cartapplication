using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class HotelProduct : IProduct
    {
        public void Save()
        {
            Console.WriteLine("hotel save");

        }
        public void Book()
        {
            Console.WriteLine("hotel save");
        }
        public string GetTypeOfProduct()
        {
            return "";
        }
    }
}
