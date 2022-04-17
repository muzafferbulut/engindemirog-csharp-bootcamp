using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // oluşturulan class yapısının kullanılması
            Kurs kurs1 = new Kurs { KursAdi = "Java", IzlenmeOrani=80, Egitmen="Engin Demiroğ"};
            Kurs kurs2 = new Kurs { KursAdi = "C#", IzlenmeOrani = 35, Egitmen = "Engin Demiroğ" };
            Kurs kurs3 = new Kurs { KursAdi = "Python", IzlenmeOrani = 100, Egitmen = "Muzaffer Bulut" };
            Kurs kurs4 = new Kurs { KursAdi = "Javascript", IzlenmeOrani = 60, Egitmen = "Berkay Bilgin" };

            // oluşturulan class nesnelerinin listesi
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("Kurs: "+kurs.KursAdi+" Egitmen: "+kurs.Egitmen);
                Console.WriteLine("----------------------");
            }

        }
    }

    class Kurs
    {
        // class yapılarına giriş. prop keywordü ile özellikler tanımlanır. 
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
