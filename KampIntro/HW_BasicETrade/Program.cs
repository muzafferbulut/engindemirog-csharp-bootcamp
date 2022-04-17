using System;

namespace HW_BasicETrade
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bir e ticaret sistemi simule edersek, ürünleri for, foreach ve while döngüleri ile ekrana basmaya çalışalım.*/
            Product product1 = new Product { ProductName = "Lenovo PC", StockQuantity = 10, Price = 15000 };
            Product product2 = new Product { ProductName = "Iphone", StockQuantity = 3, Price = 7000 };
            Product product3 = new Product { ProductName = "Xiaomi", StockQuantity = 7, Price = 4500 };
            Product product4 = new Product { ProductName = "Lamp", StockQuantity = 97, Price = 17 };
            Product product5 = new Product { ProductName = "Cologne", StockQuantity = 80, Price = 25 };

            Product[] products = new Product[] { product1, product2, product3, product4, product5 };
            
            // for döngüsü
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Name: " + products[i].ProductName);
                Console.WriteLine("Stock: " + products[i].StockQuantity); 
                Console.WriteLine("Price: "+products[i].Price);
                Console.WriteLine("****************");
            }

            // foreach döngüsü
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName+" "+product.StockQuantity+" "+product.Price);
            }


            // while döngüsü
            int a = 0;
            while (a<products.Length)
            {
                Console.WriteLine("Name: " + products[a].ProductName);
                Console.WriteLine("Stock: " + products[a].StockQuantity);
                Console.WriteLine("Price: " + products[a].Price);
                Console.WriteLine("****************");
                a++;
            }
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public int StockQuantity { get; set; }
        public int Price { get; set; }
    }
}
