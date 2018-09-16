using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
    
        static void Main(string[] args)
        {

            FileRepository.Instance.Add("main file called");

            UserChoice userChoice = new UserChoice();
            IProduct product = (IProduct)userChoice.GetChoice();
            UserActivity userActivity = new UserActivity();

            userActivity.Activity(product);
        
            Console.ReadKey();

        }
    }
}


