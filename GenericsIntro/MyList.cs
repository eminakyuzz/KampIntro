using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{//kendi list imizi yazmak
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //geçici dizinin referansı items ın referansı oluyor ve eski dizinin elemanları geçici olarak burada tutuluyor*****
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; 
            }
            items[items.Length - 1] = item;
        }
    }
}
