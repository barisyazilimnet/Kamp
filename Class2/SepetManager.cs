using System;
using System.Collections.Generic;
using System.Text;

namespace Class2
{
    class SepetManager
    {
        public void Ekle(Product product) //diger sayfalarda sepetmenager e verilmiş olan veriyi product degişkenine aktarır
        {
            Console.WriteLine("Sepete eklendi :" + product.UurunAdi);
        }
    }
}
