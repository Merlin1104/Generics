using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class SmallStack
    {
        //nasa vlastna trieda
        private int[] pole = new int[10];
        private int index = 0; //ukazuje kde sme, index kt ukazuje na vrchol zasobniku


        public void Push(int cislo)
        {
            if (index == pole.Length-1 ) //index je uz na konci pola a preto nesmiem pridat, vyhadzujem vynimku
            {
                throw new IndexOutOfRangeException();
            }
            pole[index] = cislo;
            index++;
        }

        public int Pop()
        {
            //int result = pole[index]; // toto je ekvivalent 
            //index--;
            //return result;
            if (index -1 < 0 )
            {
                throw new IndexOutOfRangeException();
            }
            return pole[index--]; 
        }

    }
}
