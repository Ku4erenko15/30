using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class DerivedClass:AClass
    {
        /// <summary>
        /// Переопределенный виртуальный метод с именем Method2
        /// </summary>
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Метод  Method2 из а.к. AClass, реализованный в производном классе DerivedClass");
        }
        /// <summary>
        /// Переопределенный абстрактный метод Method3
        /// </summary>
        public override void Method3()
        {
            Console.WriteLine("Метод Method3 из класса AClass, реализованный в производном классе DerivedClass");
        }
        /// <summary>
        /// Переопределенный абстрактный метод Method4
        /// </summary>
        public override void Method4()
        {
            Console.WriteLine("Метод Method4 из класса AClass, реализованный в производном классе DerivedClass");
        }
    }
}
