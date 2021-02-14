using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductText();
            //CategoryText();
        }

        private static void CategoryText()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryId + " " + item.CategoryName);
            }
        }

        private static void ProductText()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductId + " " + item.ProductName + " / " + item.CategoryName + " " + item.UnitsInStock);
                }

            }
            else
            {
                Console.WriteLine(result.Message);

            }
        }
    }
}
