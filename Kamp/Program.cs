using System;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            // kurslar dizisi tanımlanmıştır
            string[] kurslar = new string[] { /* string ifadeler arasına virgül konarak yazılabilir */ };
            Console.WriteLine(kurslar[ /* kaçıncı eleman */ ]); // ekrana çıktı verir
            Console.WriteLine(kurslar.Length); // kaç tane lemena oldugunu söler
            foreach (string kurs in kurslar) //kursların dizisinin içindeki tek tek doşalarak kurs degişkenine atar
            {

            }
        }
    }
}
