using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 32 до 127");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number) || (number < 32) || (number > 127)) //если вводятся некоректные данные будет ввыведена следующее сообщение
            {
                Console.WriteLine("введены некорректные данные");
            }
            
            Console.WriteLine((char)(number));


        }
    }
}
