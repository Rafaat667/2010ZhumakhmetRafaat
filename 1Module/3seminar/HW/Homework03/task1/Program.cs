using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        /*
         * Написать метод, находящий трехзначное десятичное число s, 
         * все цифры которого одинаковы и которое представляет собой сумму первых членов натурального ряда,
         * то есть s = 1+2+3+4+… 
         * Вывести полученное число, количество членов ряда и условное изображение соответствующей суммы, 
         * в которой указаны первые три и последние три члена, а средние члены обозначены многоточием. 
         * Например, если последний член равен 25, то вывести: 1+2+3+…+23+24+25
         */

        public static void myMethod (double s, double a1, double an, string output)
        {
            double dis;

            do  //находим число подходящее.
            {
                s = s + 111;

                dis = Math.Sqrt(1 + 8 * s);
            } while (dis - (int)dis != 0);

            Console.WriteLine(s);

            do  //находим количество цифр последовательности.
            {
                a1++;
                an = an + a1;
            } while (an != s);

            Console.WriteLine(a1);

            for (int i = 1; i < a1; i++) //выводим сумму всех чисел последовательности.
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

            myMethod(s,a1,an,output);//вывод метода.
        }
    }
}
