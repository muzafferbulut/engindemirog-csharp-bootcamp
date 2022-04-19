using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        /* Bir operasyon sınıfı oluşturalım ve buraya ürüne ait operasyonları bu sınıf altına ekleyelim. */

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
    }
}
