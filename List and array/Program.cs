using System;

namespace List_and_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" }; //names adlı array / dizi oluşturdu
            // buna sonradan eleman eklenemez
            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" }; // names2 adlı liste oluşturuldu
            // sonradan eleman eklenebilir
            names2.Add("İlker");

            MyList<string> names3 = new MyList<string>();// kendi yazdıgımız listeyi kullandık
            //class ismi<hangi veri tipi olacak>
            names3.Add("Barış");
            MyList<int> numbers = new MyList<int>();
            numbers.Add(10);

            //sonrasında kullanılabilir
            names3.Add("Merve");
            names3.Add("Kübra");
            numbers.Add(15);
        }
    }
}
