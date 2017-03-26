using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("studies fine");
        }
        public override void Read()
        {

            Console.WriteLine("reads fine");
        }
        public override void Write()
        {

            Console.WriteLine("writes fine");
        }
        public override void Relax()
        {
            Console.WriteLine("relaxes fine");
        }

        public ExcelentPupil(string name, int grade, double score)
            : base(name, grade, score)
        { 
            
        }
    }
}
