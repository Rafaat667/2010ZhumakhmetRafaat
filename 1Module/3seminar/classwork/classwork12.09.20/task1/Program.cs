using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static void myMethod (int a, int b, int c)
        {
            double d, res, res1;
            
            if (a==0 && b==0 && c==0)
            {
                Console.WriteLine("корней нет");
            }
            else if (a==0 && b==0)
            {
                Console.WriteLine("корней нет");
            }
            else
            {
                d = Math.Pow(a, 2) - 4 * a * c;
            }
        }
        
        static void Main(string[] args)
        {
            int a, b, c;
            string vvod1, vvod2, vvod3;
            
            Console.WriteLine("введите коэффицент А");
            vvod1 = Console.ReadLine();

            Console.WriteLine("введите коэффицент B");
            vvod2 = Console.ReadLine();

            Console.WriteLine("введите коэффицент C");
            vvod3 = Console.ReadLine();

            while (!int.TryParse(vvod1, out a) | !int.TryParse(vvod2, out b) | !int.TryParse(vvod3, out c))
            {
                Console.WriteLine("возникла ошибка при вводе!");
            }


        }
    }
}
