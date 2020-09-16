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
         * Получить от пользователя три вещественных числа и проверить для них неравенство треугольника.
         * Оператор if не применять. Точность вывода три знака после запятой.
         */
        public static string myMethod(int a, int b, int c)
        {
            string poverka;
            return poverka = (a + b) > c ? ((a + c) > b ? ((c + b) > a ? $"неравенсто треугольников, применимо к этим числам" :    //если все сходится выводит что все око
                                                                         $"неравенсто треугольников, неприменимо к этим числам") : //не совпадает не ок 
                                                                         $"неравенсто треугольников, неприменимо к этим числам") : 
                                                                         $"неравенсто треугольников, неприменимо к этим числам";
        }
        
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();//чищу экран

                int a,
                    b,
                    c;
                string input,
                       input1,
                       input2;

                Console.Write("введите первое число ");
                input = Console.ReadLine();
                Console.Write("введите второе число ");
                input1 = Console.ReadLine();
                Console.Write("введите третье число ");
                input2 = Console.ReadLine();

                while (!int.TryParse(input, out a) || !int.TryParse(input1, out b) || !int.TryParse(input2, out c))//ловлю исключения
                {
                    Console.WriteLine("Ошибка при вводе!");                                                        //альтернатива do while
                    goto Finish;
                }

                Console.WriteLine(myMethod(a,b,c));

            Finish:
                Console.WriteLine("нажмите ESC для выхода");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//выход на эскейп :)
        }
    }
}
