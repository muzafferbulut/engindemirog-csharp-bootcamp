using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="PC"},
                new Category{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, ProductName="Acer Laptop", QuantityPerUnit="32GB RAM", UnitInStock=5, UnitPrice= 24000},
                new Product{ProductId=2, ProductName="Asus Laptop", QuantityPerUnit="16GB RAM", UnitInStock=3, UnitPrice= 18000},
                new Product{ProductId=3, ProductName="HP Laptop", QuantityPerUnit="8GB RAM", UnitInStock=2, UnitPrice= 14000},
                new Product{ProductId=4, ProductName="Samsung Telefon", QuantityPerUnit="4GB RAM", UnitInStock=15, UnitPrice= 4000},
                new Product{ProductId=5, ProductName="Apple Telefon", QuantityPerUnit="4GB RAM", UnitInStock=5, UnitPrice= 8000}
            };


            Console.WriteLine("----- Algoritmik -----");

            foreach (var product in products)
            {
                // bu işlemi daha da ileri götürerek gelen sonuca kategori de eklemek istersek iş yükümüz artar. Linq ile daha
                // iyi bir çözüm sunabiliriz.

                if (product.UnitPrice>15000 && product.UnitInStock>=3)
                {
                    Console.WriteLine(product.ProductName);
                }
                
            }

            Console.WriteLine("----- Linq -----");

            // Yukarıdaki if bloğunun linq'teki karşılığı
            var result = products.Where(p=>p.UnitPrice>15000 && p.UnitInStock>=3);

            // linq olmasa yazılacak fonksiyon
            GetProducts(products);

            // linq ile yazılacak fonsiyon
            GetProductsLinq(products);

        }

        static List<Product> GetProducts(List<Product> products)
        {
            // linq olmasaydı filtrelenenleri bir liste olarak geri döndürmemiz gerekecekti.
            List<Product> filteredProduct = new List<Product>();

            foreach (var product in products)
            {

                if (product.UnitPrice > 15000 && product.UnitInStock >= 3)
                {
                    filteredProduct.Add(product);
                }

            }

            return filteredProduct;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitInStock >= 3 && p.UnitPrice > 15000).ToList();
        }
    }
}
