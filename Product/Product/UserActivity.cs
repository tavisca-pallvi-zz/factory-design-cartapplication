using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class UserActivity
    {

        private IRepository storageType;
        public void Activity(IProduct prod)
        {
            UserChoice userChoice=new UserChoice();
            FareDecorator prodFare = new FareDecorator();//wnaated to dcorate product with fare
            prodFare.GetActualFare(prod);
            
            storageType = (IRepository)userChoice.GetChoice();//converting object
            ProductService productService = new ProductService();
            char optdatabase;
            Console.WriteLine("Enter which operartion you want to perform: 1:save 2:book ");
            int option = Int32.Parse(Console.ReadLine());
            switch (option)
            {

                case 1:
                    {
                        FileRepository.Instance.Add("Product Service method save called");
                        productService.Save(prod,storageType);

                        Console.WriteLine("Enter where you want to add: 'F':file 'D':database ");
                        optdatabase = Console.ReadKey().KeyChar;
                        break;
                    }
                case 2:
                    {

                        FileRepository.Instance.Add("Product service method book is called");
                        productService.Book(prod, storageType);

                        break;
                    }
            }
        }
    }
}