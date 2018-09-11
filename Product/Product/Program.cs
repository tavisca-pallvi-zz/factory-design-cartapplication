using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {

        private static FileRepository fileob = FileRepository.Instance;
  
        static void Main(string[] args)
        {

            fileob.Add("main file called");
            CreateType createType = new CreateType();
            IProduct prod = null;
            CreateStrategy createStrategy = new CreateStrategy();
            ProductService productService = new ProductService();
            Console.WriteLine("Enter the type of product you want :");
            string itemType = Console.ReadLine();
            CacheService Cacheobj = new CacheService();

        

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
            IRepository storageType;
            ICache CacheType = new MemoryCachess();
            CacheDecorators CacheDec = new CacheDecorators();
            CacheDec.CheckForCache(CacheType,prod);
            CacheDec.CheckForCache(CacheType, prod);

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
                                     storageType = new FileStorage();
                                    storageType.Add(prod, CalFare.ProductFare(prod));
                                    break;
                                }
                            case 'D':
                                {
                                    string ms = "pradded database";
                                    //if (cache.Get(itemType) == null)
                                    //{
                                    //    cacheobj.AddToCache(itemType);
                                    //}
                                        fileob.Add("SQL STORAGE STORAGETYPE SELECTED");

                                     storageType = new SqlRepository();
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
                                    storageType = new FileStorage();
                                    storageType.Add(prod, CalFare.ProductFare(prod));
                                    break;
                                }
                            case 'D':
                                {
                                    string ms = "pradded database";
                                    fileob.Add("SQL STORAGE STORAGETYPE SELECTED");
                                    storageType = new SqlRepository();
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
    


