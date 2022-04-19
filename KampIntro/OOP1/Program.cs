﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2; // mobilya kategorisi olsun
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, ProductName = "Kalem", CategoryId = 5, UnitInStock = 5, UnitPrice = 35 };

            ProductManager productManager = new ProductManager(); // belleğin heap kısmında bir örnek oluştu

            productManager.Add(product1);
            
        }
    }
}
