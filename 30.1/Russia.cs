﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._1
{
    class Russia : Person
    {
        public Russia(string name) { Name = name; }

        public override void SayHello()
        { Console.WriteLine($"{Name} говорит: привет");}

       
    }
}
