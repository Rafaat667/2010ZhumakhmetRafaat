using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
       
        public static void myMethod (double s, double a1, double an, string output)
        {
            double dis;

            do
            {
                s = s + 111;

                dis = Math.Sqrt(1 + 8 * s);
            } while (dis - (int)dis != 0);

            Console.WriteLine(s);

            do
            {
                a1++;
                an = an + a1;
            } while (an != s);

            Console.WriteLine(a1);

            for (int i = 1; i < a1; i++)
            {
                output = output + $"{i}+";
            }
            Console.WriteLine(output + a1);
        }
        static void Main(string[] args)
        {
            double a1 = 0,
                   an = 0,
                    s = 0;
            string output = "";


            myMethod(s,a1,an,output);
        }
    }
}
