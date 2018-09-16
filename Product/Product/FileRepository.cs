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

       public string path=@"C:\file.txt";
        //private IProduct product;
        private FileRepository() {
            
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
        public void Add(string msg)
        {

            using (StreamWriter writer = File.AppendText(path))
            {

                writer.WriteLine(msg);
            }

        }

    }
}
