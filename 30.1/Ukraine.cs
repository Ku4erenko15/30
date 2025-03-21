using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._1
{
    class Ukraine : Person
    {
        public Ukraine(string name) { Name = name; }

        public override void SayHello()
        { Console.WriteLine($"{Name} говорит: Здравствуй"); }
    }
}
