using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    class Program
    {

        /* 
        Задан круг с центром в начале координат и радиусом R=10.   
        Ввести  координаты точки и вывести сообщение:   «Точка внутри круга!» или «Точка вне круга!».
        Предусмотреть проверку входных данных и цикл повторения решений.  
        */

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();//чищу консоль
                
                double x, y;
                string input1, input2;

                Console.Write("введите координаты точки по X:");
                input1 = Console.ReadLine();
                Console.Write("введите кординаты точки по Y:");
                input2 = Console.ReadLine();

                while (!double.TryParse(input1, out x) || !double.TryParse(input2, out y))  //если ввод некорректный
                {
                    Console.WriteLine("Ошибка при вводе!");                                 //альтернатива do while
                    goto Finish;
                }

                string proverka = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= 100 ? "эта точка входит в окружность" : "эта точка не входит в окружность"; //проверка на правильность

                Console.WriteLine(proverka);  //сделать строчку 38 и 40 методом

                Finish:
                Console.WriteLine("нажмите ESC для выхода");
            }
            while (Console.ReadKey(true).Key!=ConsoleKey.Escape);  //для выхода нажать ескейп :)

        }
    }
}
