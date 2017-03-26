using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom 
{
    class BadPupil : Pupil
    {
        public override void Study() {
            Console.WriteLine("studies bad");
        }
        public override void Read() {

            Console.WriteLine("reads bad");
        }
        public override void Write() { 
            
            Console.WriteLine("writes bad"); 
        }
        public override void Relax() {
            Console.WriteLine("relaxes bad");
        } 

        public BadPupil(string name, int grade, double score):base(name, grade, score) { 
            
        }
    }
}
