using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsolUI
{
    // SOLID : O:Open Closed Priciple Mevcut koda dokunulmadı sadece ef geldi.
    class Program
    {
        static void Main(string[] args)
        {
            // ProductTest();

            //CategoryTest();

            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
            
          
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            foreach (var product in productManager.GetByUnitPrice(20, 100).Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
