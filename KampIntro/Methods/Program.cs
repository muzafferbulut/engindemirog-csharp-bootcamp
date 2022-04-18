using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Metotlar bir kodu tekrar tekrar kullanabilmemizi sağlayan yapılardır. Kendimizi tekrar
             edeceğimiz kod bloklarımız olduğunda bunları fonksiyon haline getirerek tekrar tekrar
            kullanımı sağlanabilir. Aynı zamanda metotlar clean code teknileri için de önem arz eder.*/

            //  BİR FONKSİYON SADECE BİR İŞ YAPAR!

            /* C# ve java gibi programlama dillerinde her şey class yapılarından meydana gelir. Metotlar
             * bu classların içine yereştirilir. */

            /* Simulasyon için bir e ticaret sisteminde sepete ekleme işlemlerini yapabileceğimiz bir
             * butonun işlevini yazalım. SepetManager sınıfını projeye ekleyelim. */

            string urunAdi = "Elma";
            double fiyati = 3.5;
            string aciklama = "Amasya elması";

            /* bu şekilde ürünleri tanımlasakta ürün sayısı arttığında sistem çalışmaz hale gelir ve mantıklı değildir.
             * class yapıları ile bu işlemler çok kolay bir şekilde gerçekleştirilebilir. Aşağıdaki gibi ürün tanımlamada
             * ve bu özelliklere erişmede bir problem yoktur. */

            // ürünler
            Urun urun1 = new Urun() { Id = 1, Adi = "Elma", Aciklama = "Amasya elması", Fiyati = 15 };
            Urun urun2 = new Urun() { Id = 2, Adi = "Karpuz", Aciklama = "Diyarbakır karpuzu", Fiyati = 80 };

            // ürünler listesi
            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type safety - tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün: " + urun.Adi);
                Console.WriteLine("Aciklama: "+urun.Aciklama);
                Console.WriteLine("Fiyat: "+urun.Fiyati);
                Console.WriteLine("--------------------------------");
            }

            // kullanmak için sınıfın örneği oluşturulur.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); // urun1 sepete eklendi 
            sepetManager.Ekle(urun2); // urun2 sepete eklendi

            sepetManager.Sil(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);

            Console.WriteLine();
            // ürünleri listeleme
            sepetManager.Listele(urunler);


        }
    }
}
