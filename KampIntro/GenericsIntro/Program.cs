using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            // ekleme fonksiyonu
            isimler.Add("Muzaffer");
            isimler.Add("Kerem");
            // boyutu veren fonksiyon
            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
