using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _30._2
{
    class Newspaper : Printduct
    {
        private int numberOfPages;
        private double costPerPage;
        private int circulation;


        public Newspaper(string name, int numberOfPages, double costPerPage, int circulation) : base(name)
        {
            NumberOfPages = numberOfPages;
            CostPerPage = costPerPage;
            Circulation = circulation;
        }


        public int NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }

        public double CostPerPage
        {
            get { return costPerPage; }
            set { costPerPage = value; }
        }

        public int Circulation
        {
            get { return circulation; }
            set { circulation = value; }
        }


        public override void Print()
        {
            Console.WriteLine($"Газета: {Name}, Количество страниц: {NumberOfPages}, Стоимость листа: {CostPerPage}, Тираж: {Circulation}");
        }

        public override double Cost()
        {
            return NumberOfPages * CostPerPage * Circulation;
        }


        public static Newspaper Enter()
        {
            Console.Clear();
            Console.Write("Введите название газеты: ");
            string name = Console.ReadLine();
            Console.Write("Введите количество листов газеты: ");
            int numberOfPages = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость одного  листа газеты: ");
            double costPerPage = double.Parse(Console.ReadLine());
            Console.Write("Введите тираж газеты:");
            int circulation = int.Parse(Console.ReadLine());
            return new Newspaper(name, numberOfPages, costPerPage, circulation);
        }
    }

}