using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "baris";
            int yas = 20;
            Kurs kurs1 = new Kurs(); //classlardan degişken oluşturma
            kurs1.Egitmen = "barış";
            Console.WriteLine("Hello World!");
        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOranı { get; set; }

        }
    
    }
}
