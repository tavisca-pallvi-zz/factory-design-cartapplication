using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class FileStorage : IRepository
    {

        private static FileRepository fileob = FileRepository.Instance;

        public string path = @"C:\filestoragerepo.txt";
        public void Add(IProduct prod, double fare)
        {
            fileob.Add("In FileRepository Add function  called");
            Console.WriteLine("file selected");
            using (System.IO.StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine(prod.itemName);
                writer.WriteLine(prod.isBooked);
                writer.WriteLine(fare);
            }

        }
        public void Get(IProduct prod)
        {
        }
    }
}
