using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // generic class. Buraya tip olarak T verdik ama istediğimizi verebiliriz.
    {
        T[] items; // metodun dışında tanımladık DİKKAT! Sınıfın bütün metotları erişebilir.
        public MyList() // constructor metot, class newlendiği anda otomatik olarak çalışır.
        {
            items = new T[0]; 
        }
        public void Add(T item)
        {
            // newlediğimiz için referans numarası değişiyor yani değerleri kaybediyoruz. O yüzden geçici dizi oluşturacağız.
            T[] tempArray = items;
            items = new T[items.Length+1]; // yeni eleman eklemek için eleman sayısını bir artırıyoruz

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item;
        }

        public int Length
        {
            get { return items.Length;  }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
