using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    class Program
    {
        /* Задача 4. 
        Написать метод с целочисленным параметром, определяющий является ли значение аргумента кодом цифры, 
        кодом буквы русского алфавита (прописной либо строчной), или ни тем и ни другим. В основной программе, 
        вводя целые числа, выводить сообщения о них: «Это цифра!», «Это буква!», «Это ни буква, ни цифра!». 
        Для выхода из программы – ESC, для повторения решения - любой символ. При анализе цифрового кода использовать тернарную операцию.
        Строку сообщения может возвращать метод, либо метод возвращает признак, а строку формирует основная программа 
        */

        public static string myMethod(uint inputNumber)
        {
            string code;

            return code =inputNumber>=(int)'А'&&inputNumber<=(int)'я'?"Это буква!":    //метод вывода ответа
                         inputNumber>=(int)'0'&&inputNumber<=(int)'9'?"Это цифра!":
                         "Это не буква и не цифра!" ;
        }
        
        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); //чищу консоль
                
                uint inputNumber;

                Console.WriteLine("введите число");
                while (!uint.TryParse(Console.ReadLine(), out inputNumber))  //если ввод некорректный
                {
                    Console.WriteLine("Произошла ошибка!");                  //альтернатива do while
                    Console.WriteLine("Попробуйте снова");
                }

                Console.WriteLine($"{myMethod(inputNumber)}");

                Console.WriteLine("Нажмите ESC для выхода");
            }
            while (Console.ReadKey(true).Key!= ConsoleKey.Escape); //для выхода нажать ескейп :)
        }
    }
}
