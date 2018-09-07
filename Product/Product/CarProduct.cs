using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class CarProduct : IProduct
    {
        public string itemname="swift";
        public int itemid=1;
        public bool isbooked;
        public string itemName
        {
            get
            {
                return itemname;
            }
            set
            {
                itemname = value;
            }
        }
        public int itemId
        {
            get
            {
                return itemid;
            }
            set
            {
                itemid = value;

            }
        }
        public bool isBooked
        {
            get
            {
                return isBooked;
            }
            set
            {

                isBooked = value;
            }
        }
        string msg = "";
        FileRepository fileob = FileRepository.Instance;
        public void Save()
        {
            msg = "carsaved";
            isBooked = false;
            fileob.AddToFile(this,msg);
            Console.WriteLine("car save");
        }
        public void Book()
        {
            msg = "carbooked";
            isBooked = true;
            fileob.AddToFile(this,msg);
            Console.WriteLine("car book");
        }
        public string GetTypeOfProduct()
        {
            return "";
        }
    }
}
