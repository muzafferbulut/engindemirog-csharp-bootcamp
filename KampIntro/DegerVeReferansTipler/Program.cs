using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Önemli bir konudur. Başka önemli konulara temel teşkil eder. */

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1); // sonuç ne olurdu?

            /* sayi1 30 olarak kalır çünkü sayisal veri tipleri olan int, decimal, float, bool değer tiplerdir.
             * Bellekte stack ve heap olarak 2 alan var. sayisal veri tiplerinin tanımlandığı yer stacktir.
             * Bu verilerde işlemler değerler üzerinden gerçekleştirilir. Yani eşitleme aşamasında değeri kullanır.
             * Değer ataması yapılır ve önceki değer ile bağlantısı kopar.
             */


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]);

            /* sayilar1[0] 999 olarak değişir çünkü array, class ve interface gibi yapılar referans tiplerdir.
             * Referans tip olduğu için (değer tiplerim işi belleğin stack kısmındaydı) new dediğimizde belleğin
             * heap kısmında (burada bir adres değeri tutulur) bir alan açılır ve oraya yazılır. Sonraki atama
             * işleminde referans numaralarını kullandığı için değişikliklerden etkilenir.
             */

        }
    }
}
