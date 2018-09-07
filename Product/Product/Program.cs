using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {

        private static FileRepository fileob = FileRepository.Instance;
        //      public IRepository storageType;


        static void Main(string[] args)
        {

            fileob.Add("main file called");
            CreateType createType = new CreateType();
            IProduct prod = null;
            CreateStrategy createStrategy = new CreateStrategy();
            ProductService productService = new ProductService();
            Console.WriteLine("Enter the type of product you want :");
            string itemType = Console.ReadLine();

            try
            {
                fileob.Add("Create type of product");
                prod = createType.GetProduct(itemType);

            }
            catch (Exception ob)
            {
                Console.WriteLine("not created type");
            }
            IProductStrategy CalFare = createStrategy.GetProductStrategy(prod);
            fileob.Add("call GetProductStrategy");

            Console.WriteLine("Enter which operartion you want to perform: 1:save 2:book ");
            int option = Int32.Parse(Console.ReadLine());
            char optdatabase;

            switch (option)
            {

                case 1:
                    {
                        fileob.Add("Product Service method save called");
                        productService.Save(prod, CalFare.ProductFare(prod));

                        Console.WriteLine("Enter where you want to add: 'F':file 'D':database ");
                        optdatabase = Console.ReadKey().KeyChar;
                        switch (optdatabase)
                        {
                            case 'F':
                                {
                                    string ms = "productsel";
                                    fileob.Add("fILESTORAGE STORAGETYPE SELECTED");
                                    IRepository storageType = new FileStorage();
                                    storageType.Add(prod, CalFare.ProductFare(prod));
                                    break;
                                }
                            case 'D':
                                {
                                    string ms = "pradded database";

                                    fileob.Add("SQL STORAGE STORAGETYPE SELECTED");

                                    IRepository storageType = new SqlRepository();
                                    storageType.Add(prod, CalFare.ProductFare(prod));
                                    break;

                                }
                        }


                        break;
                    }
                case 2:
                    {

                        fileob.Add("Product service method book is called");
                        productService.Book(prod, CalFare.ProductFare(prod));

                        Console.WriteLine("Enter where you want to add: 'F':file 'D':database ");
                        optdatabase = Console.ReadKey().KeyChar;
                        switch (optdatabase)
                        {
                            case 'F':
                                {
                                    string ms = "productsel";
                                    fileob.Add("fILESTORAGE STORAGETYPE SELECTED");
                                    IRepository storageType = new FileStorage();
                                    storageType.Add(prod, CalFare.ProductFare(prod));
                                    break;
                                }
                            case 'D':
                                {
                                    string ms = "pradded database";

                                    fileob.Add("SQL STORAGE STORAGETYPE SELECTED");

                                    IRepository storageType = new SqlRepository();
                                    storageType.Add(prod, CalFare.ProductFare(prod));
                                    break;

                                }
                        }

                        break;


                    }



            }


            Console.ReadKey();

        }
    }
}


