using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface yapıları da o interface'i implemente eden sınıfın referans numarasını tutabilir.
            // interface yapıları newlenemez!!

            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            // ıhtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            // tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();

            Console.WriteLine();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, new DatabaseLoggerService());
            basvuruManager.BasvuruYap(ıhtiyacKrediManager, new SMSLogger());
            basvuruManager.BasvuruYap(konutKrediManager, new FileLoggerService());
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new FileLoggerService());

            Console.WriteLine();

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            /* interface yapılarını birbirinin alternatifi olan ama kod içerikleri farklı olan durumlarda kullanırız. */



        }
    }
}
