using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Russia("Petr"));
            people.Add(new Ukraine("Lisa"));


            foreach (Person person in people)
            { person.SayHello(); } 


        }
    }
}
