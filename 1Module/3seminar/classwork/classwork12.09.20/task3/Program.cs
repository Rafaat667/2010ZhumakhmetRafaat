using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double  a,
                    ploshad,
                    delta;

            Console.Write("введите свою оценку: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("ошибка при вводе!");
            }

            Console.Write("введите свою оценку: ");
            while (!double.TryParse(Console.ReadLine(), out delta))
            {
                Console.WriteLine("ошибка при вводе!");
            }

            double fa = Math.Pow(a, 2);
        }
    }
}
