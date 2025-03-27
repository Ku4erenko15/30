using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _30._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Printduct> products = new List<Printduct>();
            //Magazine magazine1 = new Magazine("Tech Mag", 5000, 2.5);
            //Newspaper newspaper1 = new Newspaper("Daily News", 12, 0.1, 20000);
            //products.Add(magazine1);
            //products.Add(newspaper1);
            //foreach (var product in products)
            //{
            //    product.Print();
            //    Console.WriteLine($"Стоимость тиража: {product.Cost()}\n");
            //}

            //Console.WriteLine("Редактирование параметров:");
            //magazine1.Circlation = 6000;
            //magazine1.Price = 3.0;
            //newspaper1.NumberOfPages = 14;
            //newspaper1.CostPerPage = 0.12;
            //foreach (var product in products)
            //{
            //    product.Print();
            //    Console.WriteLine($"Стоимость тиража: {product.Cost()}\n");
            //}



            //1-й способ

            //Printduct pressa = new Magazine("Информация образования",100,24.5);
            //pressa.Print();
            //Console.WriteLine("Стоимость тиража:" + pressa.Cost() + "руб.");
            //Console.WriteLine();
            //Magazine magazine=new Magazine("Информатика",150,27.5);
            //magazine.Print();
            //Console.WriteLine("Стоимость тиража:" + magazine.Cost() + "руб."); 
            //Console.WriteLine();
            //Newspaper newspaper = new Newspaper("Комсомольская правда", 4, 0.15, 500);
            //newspaper.Print();
            //Console.WriteLine($"Стоимость тиража:" + magazine.Cost()+ "руб.");



            //"2-й способ

            //List<Printduct> pressa = new List<Printduct>();
            //pressa.Add(new Magazine("Информатизация образоания", 100, 24.5));
            //pressa.Add(new Newspaper("Комсомольская правда", 4, 0.15,500));
            //foreach (Printduct p in pressa)
            //{
            //    p.Print();
            //    Console.WriteLine("Стоимость тиража:" + p.Cost() + "руб.");
            //}



            //3-й способ

            List<Printduct> pressa = new List<Printduct>();
            bool flag = true;
            do 
            { 
                    Console.WriteLine("Введите название печатной продукции:");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "m": case "M":
                        {
                            pressa.Add(Magazine.Enter()); break;
                        }
                    case "n": case "N":
                        {
                            pressa.Add(Newspaper.Enter()); break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет такой печатной продукции"); break;
                        }
                }
                foreach (Printduct p in pressa)
                    {
                    p.Print(); Console.WriteLine("Стоимость тиража:" + p.Cost() + " руб.");
                    }
            }
            while (flag);
        }








     
        }
    }

