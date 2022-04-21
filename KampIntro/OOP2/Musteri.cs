using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri // ebeveyn class
    {
        // özellik sınıfı

        /* Eğer bir nesnede bir değeri kullanmak zorunda değilsek orada bir soyutlama hatası
         * yapıyor olabiliriz. Mesela bir müşteri yönetim sisteminde gerçek ve tüzel kişilerin
         * aynı sınıfta ifade edilmesi buna bir örnek olabilir. */
        public int Id { get; set; } // ortak alanların ebeveyn sınıfta yer alması yeterli
        public string MusteriNo { get; set; }
    }
}
