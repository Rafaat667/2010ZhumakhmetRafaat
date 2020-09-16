using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение напряжения U=");
            double U = double.Parse(Console.ReadLine());

            Console.Write("Введите значение сопротивления R=");
            double R = double.Parse(Console.ReadLine());

            if (R != 0) //нельзя делить на ноль
            {
                Console.WriteLine($"Значение силы тока I={U/R}");

                Console.WriteLine($"Значение потребляемой мощности P={U * U / R}");
            }
            else
                Console.WriteLine("Ошибка");
        }
    }
}
