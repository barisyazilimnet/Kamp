
using System;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //1. ürün ekleme şekli
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product // 2. ürün eklemesi
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 5
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
