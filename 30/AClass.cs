using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    /// <summary>
    /// Абстрактный класс
    /// </summary>
    abstract class AClass
    {
        /// <summary>
        /// Обычный метод
        /// </summary>
        public void Method1() =>
            Console.WriteLine("Оьычный метод Mathod1 из а.к. AClaas");
        /// <summary>
        /// Виртуальный метод
        /// </summary>
        public virtual void Method2() =>
            Console.WriteLine("Виртуальный метод  Method2 из а.к. AClass");
        /// <summary>
        /// (Нериализованный(нет тела)) абстрактный метод
        /// </summary>
        public abstract void Method3();

        public abstract void Method4();
    }
}
