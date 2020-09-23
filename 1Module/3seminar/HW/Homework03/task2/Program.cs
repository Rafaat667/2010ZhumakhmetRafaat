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
         * Написать метод, преобразующий число переданное в качестве параметра в число, 
         * записанное теми же цифрами, но идущими в обратном порядке. 
         * Например, 1024 - > 4201, 120 -> 21
         */
        public static void reverseNumber(int a)
        {
            //превращяем в стринг.
            string word = a.ToString();
            //превращаем в массив.
            char[] array = word.ToCharArray();
            //разворачиваем массив.
            Array.Reverse(array);
            //превращаем в стринг обратно.
            word = new string(array);
            //выводим ответ.
            Console.WriteLine(word);
        }
        
        static void Main(string[] args)
        {
            int a;

            while (!int.TryParse(Console.ReadLine(), out a)) //ловим исключения.
            {
                Console.WriteLine("incorrect input");
            }

            reverseNumber(a); //вывод метода.
        }
    }
}
