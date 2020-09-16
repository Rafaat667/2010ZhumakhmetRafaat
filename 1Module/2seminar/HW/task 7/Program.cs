using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        /*
         * Получить от пользователя вещественное значение – бюджет пользователя и целое число – процент бюджета, 
         * выделенный на компьютерные игры. Вычислить и вывести на экран сумму в рублях\евро или долларах,
         * выделенную на компьютерные игры. Использовать спецификаторы формата для валют.
         */

        public static void myMethod(double budzhet, double procent)
        {
            double chastProcenta,
                   res;

            chastProcenta = procent / 100;
            res = budzhet * chastProcenta; 


            //вывод значения с долларом
            Console.WriteLine(string.Format(new CultureInfo("en-US"), "{0:c3}", res)) ; //fr-FR евро, ru-RU рубли
        }
        
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();//чищу экран

                double budzhet,
                    procent;
                string vvod,
                       vvod2;

                Console.Write("введите выделенный бюджет: ");
                vvod = Console.ReadLine();
                Console.Write("введите процент потраченный на видео игры: ");
                vvod2 = Console.ReadLine();

                while (!double.TryParse(vvod, out budzhet)|!double.TryParse(vvod2,out procent))//ловлю исключения
                {
                    Console.WriteLine("Ошибка при вводе!");                                    //альтернатива do while
                    goto Finish;
                }

                Console.Write("деньги потраченные на видео игры = ");
                myMethod(budzhet, procent);

            Finish:
                Console.WriteLine("для выхоа нажмите ESC");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);//выход на эскейп :)
        }
    }
}
