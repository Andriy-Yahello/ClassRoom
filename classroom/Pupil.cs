using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Pupil 
    {
        
        public string Name
        {
        set; get;
        }
        public int Grade
        {
            set;
            get;
        }

        public double Score
        {
            set;
            get;
        }

        
        public virtual void Study() {

            Console.WriteLine("average student");
        }
        public virtual void Read() {
            Console.WriteLine("average reader");
        } 
        public virtual void Write() {
            Console.WriteLine("average writer");
        }  
        public virtual void Relax() {
            Console.WriteLine("average relax");
        }

        public Pupil(string name, int grade, double score) { 
            this.Name = name;
            this.Grade = grade;
            this.Score = score;
        }
    }
}
