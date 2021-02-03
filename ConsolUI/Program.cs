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
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(20,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
