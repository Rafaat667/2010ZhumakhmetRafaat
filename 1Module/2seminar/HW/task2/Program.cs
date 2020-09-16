using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {

        /*
         * Ввести натуральное трехзначное число Р.
         * Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.
         */

        public static void myMethod(int P)
        { 
        int sotaya,
            desyataya,
            posled,
            max,
            sred,
            min;

            sotaya = P / 100;                                //первая цифра числа 
            desyataya = (P - (100 * sotaya)) / 10;           //вторая цифра числа 
            posled = P - (100 * sotaya) - (10 * desyataya);  //третья цифра числа

            max = sotaya > desyataya ? (sotaya > posled ? sotaya : posled) : (desyataya > posled ? desyataya : posled); //узнаем максимальную цифру в заданом числе
            min = sotaya < desyataya ? (sotaya < posled ? sotaya : posled) : (desyataya < posled ? desyataya : posled); //узнаем минимальное
            sred = sotaya == max && min == desyataya ? posled : (sotaya == max && min == posled ? desyataya :           //узнаем среднее
                    (max == desyataya && min == posled ? sotaya : (max == desyataya && min == sotaya ? posled :        
                    (posled == max && sotaya == min ? desyataya : sotaya))));
            /* a = x > y ? (y > z ? $"{z}; {y}; {x}" : (x > z ? $"{y}; {z}; {x}" : $"{y}; {x}; {z}")) : 
                  (x > z ? $"{z}; {x}; {y}" : (y > z ? $"{x}; {z}; {y}" : $"{x}; {y}; {z}")) ;*/ //альтернатива этому методу

            Console.WriteLine($"{max}{sred}{min}");
        }
        
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();//чищу консоль при повторе 
                
                int P;
                string input;

                Console.Write("введите трехзначное число: ");
                input = Console.ReadLine();

                while (!int.TryParse(input, out P)||P>999||P<100)//ловим исключения
                {
                    Console.WriteLine("Ошибка при вводе!");      //альтернатива do while
                    goto finish;
                }

                myMethod(P);

               finish:
                Console.WriteLine("нажмите ESC для выхода");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//выход на эскейп :)
        }
    }
}
