using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        /*
         * Написать метод, вычисляющий значение функции G=F(X,Y) 
         * G = { x+sin(y), x<y и x>0
         *     { y-cos(x), x>y и x<0
         *     { 0.5*x*y, в остальных случаях
         */

        public static void funkciya(double x, double y)
        {
            double resultat;

            //вставляем данную нам функцию.
            resultat = x < y && x > 0 ? (x + Math.Sin(y)) : x > y && x < 0 ? (y - Math.Cos(x)) : (0.5 * x * y);

            //выводим ответ, только 2 знака после запятой.
            Console.WriteLine(resultat.ToString("F2"));
        }
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите x и y");

            //ловим исключения.
            while (!double.TryParse(Console.ReadLine(), out x) || !double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Incorrect input!");
            }

            //выводим метод.
            funkciya(x, y);
        }
    }
}
