using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryCalismasi
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] Keys;
        TValue[] Values; //key ve value değerlerini tutmak için iki dizi tanımladık.

        //Constructor
        public MyDictionary()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
            //default olarak 0.indexteki değerleri atadık.

        }
        public void Add(TKey key,TValue value)
        {
            // değerleri kaybetmemek için temp değişkenlerinde dizinin önceki kopyası tutulur.

            TKey[] TempKey = Keys;
            TValue[] TempValue = Values;

            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            //for döngüsüyle templer içerisindeki değerleri şimdiki alana aktaralım.

            for (int i = 0; i < TempKey.Length;i++)
            {
                Keys[i] = TempKey[i];
                Values[i] = TempValue[i];
            }

            //şimdide son değerride ekleyelim.
            Keys[Keys.Length - 1] = key;
            Values[Values.Length - 1] = value;


        }

        public int Length
        {
            get { return Keys.Length; }
        }
        public TKey[]keys
        {
            get { return Keys; }
        }
        public TValue [] values
        {
            get { return Values; }
        }

        //Liste elemanlarını listeleyen metod.
        public void List()
        {
            for(int i=0;i<Keys.Length;i++)
            {
                Console.WriteLine(Keys[i]+" " +Values[i]);
            }
        }
    }
}
