using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonnyZoznam telefonnyZoznam = new TelefonnyZoznam();
            telefonnyZoznam.PridajStudenta(new Student { TelCislo = "123456", RodneCislo = "45678975", Meno = "Michal Rychly" });
            telefonnyZoznam.PridajStudenta(new Student { TelCislo = "987565", RodneCislo = "11111111", Meno = "Jozo Pomaly" });
            telefonnyZoznam.PridajStudenta(new Student { TelCislo = "123456", RodneCislo = "11112222", Meno = "Fero Ish" });

            Student student = new Student();
            if (telefonnyZoznam.Find("123456", out student))
            {
                Console.WriteLine(student.Meno);
                Console.WriteLine(student.RodneCislo);
            }
            else
            {
                Console.WriteLine("Zaznam nieje v telefonnom zozname");
            }

            GenericSmallStack<string> genericSmallStack = new GenericSmallStack<string>();
            genericSmallStack.Pop(); // ak toto pustime tak to padne a vyhodi exception

            Console.ReadLine();
        }
    }
}
