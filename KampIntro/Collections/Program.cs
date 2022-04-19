using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" }; // heapte 4 elemanlı bir yer oluştu.
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            // diziye yeni bir eleman eklemek istersek hata alacağız
            //isimler[4] = "Muzaffer"; // indeks sınırların dışında hatası alınır.

            /* Array yapıları sadece oluşturulurken verilen sınırlar içerisinde gezer, o sınırlar dışına çıkamaz.
             * Peki newleyemez miyiz? Hayır newleyemeyiz. Çünkü new dediğimiz anda bellekte yeni bir adres oluşur
             * ve dizideki diğer elemanların silinmesi gerçekleşir. Yeni dizilerin problemi dizileri genişletemiyoruz
             * ya da değerleri kaybediyoruz. Bu tür durumlarda farklı bir çözüm yolu olarak koleksiyonlar
             * kullanılır. Günlük hayat uygulamalarında çoğunlukla array yerine koleksiyonlar kullanılır. */

            // yukarıdaki kodu farklı bir açıdan bakış

            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            isimler2.Add("Muzaffer");

            foreach (string isim in isimler2)
            {
                Console.WriteLine(isim);
            }

            // Peki C# List'e sahip olmasaydı ne olur? Kendi koleksiyonumuzu nasıl yazardık?



        }
    }
}
