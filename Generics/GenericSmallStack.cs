using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericSmallStack<T> //toto je genericky small stack kt sme spravili tak, ze sme skopcili SmallStack a poprepisovali vsetky int na T a zaroven sme pridali <T> za GenericSmall Stack + toto je nova Classa kt sme nazvali GenericSmallStack
    {
        //nasa vlastna trieda
        private T[] pole = new T[10];
        private int index = 0; //ukazuje kde sme, index kt ukazuje na vrchol zasobniku


        public void Push(T obj)
        {
            if (index == pole.Length - 1) //index je uz na konci pola a preto nesmiem pridat, vyhadzujem vynimku
            {
                throw new IndexOutOfRangeException();
            }
            pole[index] = obj;
            index++;
        }

        public T Pop()
        {
            //int result = pole[index]; // toto je ekvivalent 
            //index--;
            //return result;
            if (index - 1 < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return pole[index--];
        }
    }
}
