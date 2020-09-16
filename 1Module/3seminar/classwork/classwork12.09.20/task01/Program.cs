using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Program
    {
       
        public static void perevod(int ocenka)
        {
            switch (ocenka)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("неуд");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("удов");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Хорошо");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("отлично");
                    break;
            }
        }
        static void Main(string[] args)
        {
            int ocenka;

            Console.Write("введите свою оценку: ");
            while (!int.TryParse(Console.ReadLine(), out ocenka) | ocenka <0 | ocenka>10)
            {
                Console.WriteLine("ошибка при вводе!");
            }

            perevod(ocenka);
        }
    }
}
