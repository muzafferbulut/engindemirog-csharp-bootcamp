using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        /* Manager ifadesi standarttır. Metot sınıflarının sonuna eklenir. */

        /* Class yapıları operasyon ve özellik tutan class olarak sınılandırılabilir. */

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Ürün eklendi: "+urun.Adi+" --Açıklama: "+urun.Aciklama);
        }

        // birden fazla metot olabilir.
        public void Ekle2(string urunAdi, string aciklama, double fiyati)
        {
            // bu metot hatalı kullanımı ifade etmek için yazıldı. bu şekilde de yazmak yerine üstteki kullanım önerilir.
            // Çünkü ilerleyen zamanlarda bir değişiklik ya da ekleme yapıldığında bu kullanım problem yaratacaktır.

            /* Bunları ayrı ayrı vermek yerine nesne şekinde vermeye encapsulation denir. Detayını araştır.  */
            Console.WriteLine("Sepete eklendi: "+urunAdi);

        }

        public void Sil(Urun urun)
        {
            Console.WriteLine(urun.Adi +" sepetten kaldırıldı.");
        }

        public void Listele(Urun[] urunler)
        {
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
            }
        }
    }
}
