using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bugünün konusu soyutlama, detaylı bir şekilde konuşacağız. Uygulamaları müşteri yönetim sistemi
             * üzerinden gerçekelştireceğiz. */

            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "56456";
            gercekMusteri.TcNo = "54454654640";
            gercekMusteri.Adi = "Muzaffer";
            gercekMusteri.Soyadi = "Bulut";

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "454564";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "44564879";

            // müşteri sınıfı hem gerçek müşterinin hem de tüzel müşterinin referansını tutabilir.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekMusteri);
            musteriManager.Ekle(tuzelMusteri);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            /* Gerçek ve tüzel müşterilerin birbirine benzeyen özelliklerinin olması aynı sınıfta 
             * temsil edilmeleri hususunda geçerli bir sebep sağlamaz. Zamanla bug free denilen
             * açıklar oluşacaktır. */
        }
    }
}
