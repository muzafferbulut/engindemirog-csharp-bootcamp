using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            Console.WriteLine("Fark: " + fark);
        }

    }
}
