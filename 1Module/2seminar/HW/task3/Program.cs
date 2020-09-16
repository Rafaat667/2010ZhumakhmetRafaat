using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        /* Задача на применение тернарной операции. 
            (Не применять оператор if.)
            Написать метод, так обменивающий значения трех переменных x, y, z, чтобы выполнилось требование: x <= y <= z. 

             В основной программе, вводить значения трех переменных и упорядочивать их с помощью обращения к написанному методу. 

            Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу. 
        */


        public static string myMethod(int x, int y, int z)
        {
            string a;

            return   ( x > y ? (y > z ? Console.WriteLine($"{x},{y},{z}") : (x > z ? Console.WriteLine($"{x},{z},{y}") : Console.WriteLine($"{z},{x},{y}"))) : (x > z ? Console.WriteLine($"{y},{x},{z}") : (y > z ? Console.WriteLine($"{y},{z},{x}") : Console.WriteLine($"{z},{y},{x}"))));
        }
        static void Main(string[] args)
        {
            int n1, n2, n3;
            string vv1, vv2, vv3, otv;

            Console.WriteLine("Введите три числа");

            vv1 = Console.ReadLine();
            vv2 = Console.ReadLine();
            vv3 = Console.ReadLine();

           if (!((int.TryParse(vv1, out n1)) || (int.TryParse(vv2, out n2)) || (int.TryParse(vv3, out n3))))
            {
                Console.WriteLine("ошибка при вводе");
            }

            n1 = int.Parse(vv1);
            n2 = int.Parse(vv2);
            n3 = int.Parse(vv3);


            otv = myMethod(n1, n2,n3);
        }
    }
}
