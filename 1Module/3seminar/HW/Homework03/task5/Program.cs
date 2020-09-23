using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        /*
         * Написать метод, вычисляющий значение функции G=F(X)
         * G = { sin(PI/2),x<=0.5
         *     { sin(PI(x-1)/2),x>0.5
         */
        public static void funkciya(double x)
        {
            //используем данную нам функцию.
            double resultat = x <= 0.5 ? Math.Sin(Math.PI / 2) : Math.Sin((Math.PI * (x - 1)) / 2);

            Console.WriteLine(resultat); //выводим ответ.
        }
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите x");

            //ловим исключения.
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Incorrect input!");
            }

            funkciya(x); //выводим метод.
        }
    }
}
