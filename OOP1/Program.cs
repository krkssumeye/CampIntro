using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            product product1 = new product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;
            //iki şekilde de gösterimini sağlayabiliriz
            product product2 = new product
            {
                ID = 2,
                CategoryId = 5,
                UnitInStock = 5,
                ProductName = "kalem",
                UnitPrice = 3
            };
            ProductManeger





        }
    }
}
