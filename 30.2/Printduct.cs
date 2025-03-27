using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._2
{
    abstract class Printduct
    {

        private string name;

        public Printduct() { }
        public Printduct (string name) { Name = name; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public abstract void Print();

        public abstract double Cost();


    }
}
