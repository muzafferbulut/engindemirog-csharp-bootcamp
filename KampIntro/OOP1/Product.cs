using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        /* Bir özellik sınıfı oluşturalımv ve buraya ürüne ait özellikleri ekleyelim. */
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
