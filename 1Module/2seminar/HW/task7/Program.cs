using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        /*
         * Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
         * Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. 
         * Программа должна вычислить, если это возможно, значение корня, квадрата числа, 
         * выделить целую и дробную часть из числа.
         */

        public static void drobnayaChast(double number) //метод для вывода целой и дробной части
        {
            int celoye = (int)number;
            double drob = Math.Round((number - celoye), 2);
            Console.WriteLine($"целая часть числа = {celoye}");
            Console.WriteLine($"дробная часть числа = {drob}");
        }

        public static void kvadrat(double number) //вывод для корней и квадратов
        {
            double kvadrat =Math.Round(Math.Pow(number, 2), 2);
            
            if (number <0) //ловим когда число отрицательное и корень не возможен 
            {
                Console.WriteLine("корней нет");
            }
            else
            {
                double koren = Math.Round(Math.Sqrt(number), 2);
                Console.WriteLine($"корень числа = {koren}");
            }
            
             Console.WriteLine($"квадрат числа = {kvadrat}");
        }
        
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();//чищу экран

                double number;
                string input;

                Console.WriteLine("введите дробное число");
                input = Console.ReadLine();

                while (!double.TryParse(input, out number))//ловим исключения
                {
                    Console.WriteLine("Ошибка при вводе!"); //альтернатива do while
                    goto Finish;
                }

                drobnayaChast(number);
                kvadrat(number); 

            Finish:
                Console.WriteLine("нажмите ESC для выхода");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//выход на эскейп :)
        }
    }
}
