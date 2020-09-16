using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static int Fib(uint n)
        {
            
            double b = (1 + Math.Sqrt(5))/2;

            double un = Math.Pow(b, n) - Math.Pow(-b, -n) / (2 * b - 1);

            return (int)(un + 0.5);
        
        }
        static void Main(string[] args)
        {
            string vvod = Console.ReadLine();
            uint n;
            if (!uint.TryParse(vvod, out n))
            {
                Console.WriteLine("error");
            }
            int res = Fib(n);
            Console.WriteLine(res);

        }
    }
}
