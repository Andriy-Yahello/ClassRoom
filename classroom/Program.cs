using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main()
        {
            

            Pupil p1 = new BadPupil("Brian", 4, 3.0);
            Pupil p2 = new GoodPupil("Mihael", 4, 4.0);
            Pupil p3 = new ExcelentPupil("Arnold", 4, 5.0);
            Pupil p4 = new BadPupil("Ben", 4, 2.0);
            
            ClassRoom class1 = new ClassRoom(p1, p2, p3, p4);
         /*   p1.Show();
            Console.WriteLine(new string('-', 50));
            p2.Show();
            Console.WriteLine(new string('-', 50));
            p3.Show();
            Console.WriteLine(new string('-', 50));
            p4.Show();
            Console.WriteLine(new string('-', 50));*/
            class1.Show();

            Console.ReadKey();

        }
    }
}
