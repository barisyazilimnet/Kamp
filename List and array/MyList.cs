using System;
using System.Collections.Generic;
using System.Text;

namespace List_and_array
{
    // kenarda çıkan ampüle basıp using System.Collections.Generic; eklemeniz lazım
    class MyList<Type>
    {
        Type[] items;
        public MyList()
        {
            items = new Type[0];
        }
        public void Add(Type item)
        {
            Type[] tempArray = items; // referans numarası kaybolmaması için geçici diziye aktarıldı
            items = new Type[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
