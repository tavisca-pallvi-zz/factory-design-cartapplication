using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class FileRepository
    {
        private static FileRepository _instance;

        private static string path=@"C:\filelog.txt";
        //private IProduct product;
        private FileRepository() {


            //System.IO.FileStream fs = new FileStream(@"C:\filelog.txt", FileMode.Append, FileAccess.Write);
        }

        public static FileRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FileRepository();
                }
                return _instance;
            }
        }
        public void  AddToFile(IProduct prod,string msg)
        {

            using (StreamWriter writer = File.AppendText(path)) 
            {
                writer.WriteLine(msg + "" + prod.itemName);
                writer.WriteLine(msg + "" + prod.isBooked);
            }


        }
    }
}
