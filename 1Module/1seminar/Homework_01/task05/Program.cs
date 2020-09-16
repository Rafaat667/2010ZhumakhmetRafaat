using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение катета а=");
            double katet1 = double.Parse(Console.ReadLine());

            Console.Write("Введите значение катета b=");
            double katet2 = double.Parse(Console.ReadLine());

            double result = Math.Sqrt((katet1 * katet1) + (katet2 * katet2));
            Console.WriteLine($"Значение гипотенузы с={result}");
        }
    }
}
