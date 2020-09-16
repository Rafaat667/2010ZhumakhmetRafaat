using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ефыл3
{
    class Program
    {

        /*
         * Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения. 
         * Учесть (как хотите) возможность появления комплексных корней. Оператор if не применять.
         */
        public static string myMethod(double a, double b, double c)
        {
            double d,
                   res,
                   res2;
            string proverka;

            d = Math.Pow(b, 2) - 4 * a * c;    //дискриминант
            res = (-b + Math.Sqrt(d)) / 2 * a; //первый корень уровнения
            res2 = (-b - Math.Sqrt(d)) / 2 * a;//второй

           return proverka = res == res2 ? $"корень = {res}":
                            (d<0)?$"корней нет":
                            $"первый корень = {res}; второй корень = {res2}"; //моменты когда корней нет или он только один
        }
        
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();//чищу экран
                
                double a,
                    b,
                    c;
                string input,
                       input1,
                       input2;

                Console.Write("введите коэффицент А: ");
                input = Console.ReadLine();
                Console.Write("введите коэффицент B: ");
                input1 = Console.ReadLine();
                Console.Write("введите коэффицент C: ");
                input2 = Console.ReadLine();

                while (!double.TryParse(input, out a) || !double.TryParse(input1, out b) || !double.TryParse(input2, out c))//ловлю исключения
                {
                    Console.WriteLine("Ошибка при вводе!");                                                                 //альтернатива do while
                    goto Finish;
                }

                Console.WriteLine(myMethod(a, b, c));
                
                Finish:
                Console.WriteLine("нажмите ESC для выхода");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//выход на эскейп :)
        }
    }
}
