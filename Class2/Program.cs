using System;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); // class tanımlaması
            product1.UurunAdi = "Karpuz";
            product1.UrunFiyati = 10;
            product1.ProductDescription = "Dikayarbakır";

            Product product2 = new Product();
            product2.UurunAdi = "Elma";
            product2.UrunFiyati = 80;
            product2.ProductDescription = "Amasya";

            Product[] products = new Product[] { product1, product2 }; // array tanımlaması

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1); // sepetmanager classı veri gönderiyor
        }
    }
}
