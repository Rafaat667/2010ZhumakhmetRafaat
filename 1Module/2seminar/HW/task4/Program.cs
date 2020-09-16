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
         * Получить от пользователя четырехзначное натуральное число
         * и напечатать его цифры в обратном порядке.
         */
        public static void myMethod(int number)
        {
            Console.WriteLine(number.ToString().Reverse().ToArray());//выводит число наоборот
        }
        
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();//чистить экран
                
                int number;
                string input;

                Console.WriteLine("введите четырехзначное  число");
                input = Console.ReadLine();

                while (!int.TryParse(input, out number) | number < 999 | number > 10000)//ловлю исключения
                {
                    Console.WriteLine("Ошибка при вводе!");                             //альтернатива do while
                    goto Finish;
                }

                Console.Write("ваше число в обратном порядке:");
                myMethod(number);

                Finish:
                Console.WriteLine("нажмите ESC для выхода");
            } while (Console.ReadKey(true).Key!=ConsoleKey.Escape);//для выхода эскейп :)
        }
    }
}
