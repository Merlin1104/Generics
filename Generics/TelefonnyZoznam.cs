using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TelefonnyZoznam
    {
        Dictionary<string, Student> zoznam = new Dictionary<string, Student>();

        public void PridajStudenta(Student student)
        {
            try
            {
                zoznam.Add(student.TelCislo, student);
            }
            // odchytenie vynimky v pripade, ze sa nepodari pridat kluc do dictionary, napr Duplicitny kluc
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                
            }
            //zoznam.Add(student.TelCislo, student); toto bolo povodne pred try a catch
        }

        public bool Find(string telCislo, out Student student)
        {
            return zoznam.TryGetValue(telCislo, out student);
        }
    }
}
