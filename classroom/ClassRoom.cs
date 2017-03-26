using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom 
    {
        Pupil p1, p2, p3, p4;
        

        public void ShowInfop1()
        {
                Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p1.Name, p1.Grade, p1.Score);
        }

        public void ShowInfop2()
        {
            Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p2.Name, p2.Grade, p2.Score);
        }

        public void ShowInfop3()
        {
            Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p3.Name, p3.Grade, p3.Score);
        }

        public void ShowInfop4()
        {
            Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p4.Name, p4.Grade, p4.Score);
        }
        public void Show()
        {
            ShowInfop1();
            p1.Study();
           
            //Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p2.Name, p2.Grade, p2.Score);
            ShowInfop2();
            p2.Study();
            
           // Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p3.Name, p3.Grade, p3.Score);
            ShowInfop3();
            p3.Study();
            //Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p4.Name, p4.Grade, p4.Score);
            ShowInfop4();
            p4.Study();
            Console.WriteLine(new string('-', 50));
            //Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p1.Name, p1.Grade, p1.Score);
            ShowInfop1();
            p1.Read();
            //Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p2.Name, p2.Grade, p2.Score);
            ShowInfop2();
            p2.Read();
            //Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p3.Name, p3.Grade, p3.Score);
            ShowInfop3();
            p3.Read();
           // Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p4.Name, p4.Grade, p4.Score);
            ShowInfop4();
            p4.Read();
            Console.WriteLine(new string('-', 50));
          //  Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p1.Name, p1.Grade, p1.Score);
            ShowInfop1();
            p1.Write();
           // Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p2.Name, p2.Grade, p2.Score);
            ShowInfop2();
            p2.Write();
           // Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p3.Name, p3.Grade, p3.Score);
            ShowInfop3();
            p3.Write();
          //  Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p4.Name, p4.Grade, p4.Score);
            ShowInfop4();
            p4.Write();
            Console.WriteLine(new string('-', 50));
          //  Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p1.Name, p1.Grade, p1.Score);
            ShowInfop1();
            p1.Relax();
         //   Console.WriteLine("Name: {0}, Grade: {1}, Overall score: {2}", p1.Name, p1.Grade, p1.Score);
            ShowInfop2();
            p2.Relax();
            ShowInfop3();
            p3.Relax();
            ShowInfop4();
            p4.Relax();
        }
        public ClassRoom() {  }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4) {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
    }
}
