 using System;

namespace MyDictionaryCalismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> esyalar = new MyDictionary<int, string>();

            esyalar.Add(1, "Lamba");
            esyalar.Add(2, "Koltuk Takımı");
            esyalar.Add(3, "Televizyon");
            esyalar.Add(4, "Halı");
            esyalar.List();

        }
    }
}
