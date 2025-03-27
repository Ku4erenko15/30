using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _30._2
{
    class Magazine : Printduct
    {
        private int circlation;
        private double price;
        public Magazine() { }
        public Magazine(string name, int circlation, double price) : base(name) { Circlation = circlation; Price = price; }

        public int Circlation { get => circlation; set => circlation = value; }
        public double Price { get => price; set => price = value; }

        public override void Print()
        {
            Console.WriteLine($"Журнал: {Name} Тираж: {Circlation} Цена: {Price} ");
        }

        public override double Cost()
        {
            return Circlation * Price;
        }

        public static Magazine Enter()
        {
            Console.Clear();
            Console.Write("Введите название журнала: ");
            string name = Console.ReadLine();
            Console.Write("Введите тираж журнала: ");
            int circulation =
            int.Parse(Console.ReadLine());
            Console.Write("Введите цену журнала: ");
            double price =
            double.Parse(Console.ReadLine());
            return new Magazine
            (name, circulation, price);
        }
    }

}

