using System;
using System.Collections.Generic;
using System.Text;

namespace HW_GenericDictionary
{
    class MyDictionary<Tkey, Tvalue> // burada anahtar değer çiftlerinin tipleri temsil edilir.
    {
        Tkey[] keys; // burada key value çiftleri array olarak tanımlanır. Bu çiftler her yerden erişilebilir durumdadır.
        Tvalue[] values;
        public MyDictionary()
        {
            /* class newlendiği anda çalışacak blok */
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            // bir temp arrayde referans numarası tutulur. Referans numarasını önceki değerleri kaybetmemek için kullanacağız.
            Tkey[] tempArrayKey = keys;
            Tvalue[] tempArrayValue = values;

            // Ekleme işlemi olduğu için dizi newlenir ve eleman sayısı bir artırılır.
            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            // bu bölümde dictionary yapısında önceden var olan değerler eklenir
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keys[i] = tempArrayKey[i];
                values[i] = tempArrayValue[i];
            }

            // parametre olarak verilen değerler eklenir
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Count
        {
            get { return keys.Length; }
        }
    }
}
