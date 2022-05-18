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
                new Product{ProductId=1, CategoryId = 1,ProductName="Acer Laptop", QuantityPerUnit="32GB RAM", UnitInStock=5, UnitPrice= 24000},
                new Product{ProductId=2, CategoryId = 1,ProductName="Asus Laptop", QuantityPerUnit="16GB RAM", UnitInStock=3, UnitPrice= 18000},
                new Product{ProductId=3, CategoryId = 1,ProductName="HP Laptop", QuantityPerUnit="8GB RAM", UnitInStock=2, UnitPrice= 14000},
                new Product{ProductId=4, CategoryId = 2,ProductName="Samsung Telefon", QuantityPerUnit="4GB RAM", UnitInStock=15, UnitPrice= 4000},
                new Product{ProductId=5, CategoryId = 2,ProductName="Apple Telefon", QuantityPerUnit="4GB RAM", UnitInStock=5, UnitPrice= 8000}
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

            // Any ile aranan değerin olup olmadığı sınanır ve bool bir değer döner.
            var acerLaptopVarMi = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(acerLaptopVarMi);

            // Find ile aranılan kriterdeki nesnenin kendisini döndürür.
            // Hiç olmayan bir değer verirsek null döndürecektir.

            var findProduct = products.Find(p => p.ProductId == 3);
            Console.WriteLine(findProduct.ProductName);

            // isminde 'top' geçen tüm verileri bir liste şeklide döndürür.
            List<Product> resultOfFindAll = products.FindAll(p => p.ProductName.Contains("top")).ToList();


            Console.WriteLine("------------------------------");
            // sıralama
            var result2 = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p=>p.UnitPrice).ThenByDescending(p=>p.ProductName);

            foreach (var p in result2)
            {
                Console.WriteLine(p.ProductName);
            }


            Console.WriteLine("------------------------------");


            // linq diğer kullanım
            var linqDigerKullanim = from p in products
                                    where p.UnitPrice < 10000
                                    orderby p.UnitPrice
                                    select p;

            foreach (var p in linqDigerKullanim)
            {
                Console.WriteLine(p.ProductName);
            }

            // DTO kullanımı ve join kullanımı
            var linqDigerKullanim2 = from p in products
                                    where p.UnitPrice < 10000
                                    orderby p.UnitPrice
                                    select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var p in linqDigerKullanim)
            {
                Console.WriteLine(p.ProductName);
            }

            Console.WriteLine("------------------------------");
            // category ile join işlemi
            var result4 = from p in products
                          join c in categories
                          on p.CategoryId equals c.CategoryId
                          select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result4)
            {
                Console.WriteLine(productDto.ProductName+" - "+productDto.CategoryName);
            }



            Console.ReadLine();
        }

        class ProductDto
        {
            // Dto - Data Transformation Object
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public string CategoryName { get; set; }
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
