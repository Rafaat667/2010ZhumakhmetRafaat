using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        public static void myMethod(double kapital, double procent, double let)
        {
            double res = kapital+(kapital * (procent / 100) * let);

            Console.WriteLine($"Оплата банку = {res}");
        }
        
        static void Main(string[] args)
        {
            double kapital, procent, let;
            
            Console.Write("введите начальный капитал =");
            while (!double.TryParse(Console.ReadLine(), out kapital))
            {
                Console.WriteLine("ошибка при вводе!");
            }

            Console.Write("введите годовой процент =");
            while (!double.TryParse(Console.ReadLine(), out procent))
            {
                Console.WriteLine("ошибка при вводе!");
            }

            Console.Write("введите количеыство лет =");
            while (!double.TryParse(Console.ReadLine(), out let))
            {
                Console.WriteLine("ошибка при вводе!");
            }

            myMethod(kapital, procent, let);
        }
    }
}
