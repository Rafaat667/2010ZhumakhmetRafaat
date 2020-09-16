using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha7
{
    class Program
    {
        /*
         * Ввести значение x и вывести значение полинома: F(x) = 12x4 + 9x3 - 3x2 + 2x – 4.
         * Не применять возведение в степень. Использовать минимальное количество операций умножения.
         */

        public static int razlozhenoyeDeistvie(int x)
        {
            int result;
            
            return result = x * (x * (x * (12 * x + 9) - 3) + 2) - 4; //сокращенное F(x) = 12x4 + 9x3 - 3x2 + 2x – 4;
                                                                      
        }
        
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();//чистит консоль после повтора
                
                int x;
                string vvod;

                Console.Write("введите x=");
                vvod = Console.ReadLine();
                while (!int.TryParse(vvod, out x))                //ловлю исключения
                {
                    Console.WriteLine("Ошибка при вводе!");       //альтернатива do while
                    goto Finish;
                }
                
                Console.WriteLine($"ответ {razlozhenoyeDeistvie(x)}");

                Finish:
                Console.WriteLine("для выхоа нажмите ESC");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);//выход на кнопку эскейп :)
        }
    }
}
