using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("studies good");
        }
        public override void Read()
        {

            Console.WriteLine("reads good");
        }
        public override void Write()
        {

            Console.WriteLine("writes good");
        }
        public override void Relax()
        {
            Console.WriteLine("relaxes good");
        } 

        public GoodPupil(string name, int grade, double score):base(name, grade, score) { 
            
        }
    }
}
