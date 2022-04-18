using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# type safety - tip güvenli bir dildir.
             * Console uygulamalarını çalıştırdığımız zaman önce main fonksiyonu çalışır.
             * Program main fonksiyonundan dallanır.
             * 
             * Programlamada temel konu kendini tekrar etmemektir. DRY (Dont Repeat Yourself)
             * 
             * Temel konular ve alıştırmalar
             */

            Console.WriteLine("Hello World!");

            // Temel veri tipleri
            string kategoriEtiketi = "Kategori"; // karakter dizileri
            int ogrenciSayisi = 32000;          // tam sayı değerleri
            double faizOrani = 32.27;           // ondalıklı sayılar
            bool isActive = true;              // boolean değer

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);
            Console.WriteLine(isActive);


            //  şart blokları
            if (isActive)
            {
                Console.WriteLine("Aktif");
            } // else if(condition){code blocks}
            else
            {
                Console.WriteLine("Pasif");
            }

            // basit bir şart bloğu örneği
            double dolarDun = 3.15;
            double dolarBugun = 3.20;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Düşüş");
            }else if(dolarDun == dolarBugun)
            {
                Console.WriteLine("Sabit");
            }
            else
            {
                Console.WriteLine("Yükseliş");
            }

        }
    }
}
