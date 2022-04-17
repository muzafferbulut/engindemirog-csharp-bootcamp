using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Döngüler, birbirine benzeyen ya da tekrar eden işlemleri
             * tekrar etmek için kullanılan yapılardır.
             */

            // basit bir döngü iskeleti
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------");
            string kurs1 = "Yazılım Geliştirme Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Programlama";
            string kurs4 = "Python Programlama"; 

            string[] kurslar = new string[] { kurs1, kurs2, kurs3, kurs4 }; // dizi tanımlama

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-----------------------------");

            // foreach yapısı dizi temelli yapıları tek tek dönmeye yarar. Dizilere uygulanır
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



        }
    }
}
