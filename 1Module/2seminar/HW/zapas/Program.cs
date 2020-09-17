using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapas
{
    class Program
    {

        /* Задача на применение тернарной операции. 
        (Не применять оператор if.)
        Написать метод, так обменивающий значения трех переменных x, y, z, чтобы выполнилось требование: x <= y <= z. 
        В основной программе, вводить значения трех переменных и упорядочивать их с помощью обращения к написанному методу. 
        Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу. 
        */
 
        public static string myMethod(int x, int y, int z)
        {
            string a;

            return a = x > y ? (y > z ? $"{z}; {y}; {x}" : (x > z ? $"{y}; {z}; {x}" : $"{y}; {x}; {z}")) : 
                               (x > z ? $"{z}; {x}; {y}" : (y > z ? $"{x}; {z}; {y}" : $"{x}; {y}; {z}")) ;
                                //метод для расстоновки всех слогаемых в порядке убывания
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); //чищу консоль

                int x, y, z;
                //string vv1, vv2, vv3;

                Console.WriteLine("Введите три числа");


                //vv2 = Console.ReadLine();
                //vv3 = Console.ReadLine();



                while (!(int.TryParse(Console.ReadLine(), out x)) || !(int.TryParse(Console.ReadLine(), out y)) || !(int.TryParse(Console.ReadLine(), out z)))  //если ввод некорректный
                {
                     Console.WriteLine("Ошибка при вводе!");                                                       //альтернатива do while
                    //goto Finish;
                }

                Console.WriteLine($"введенные числа в порядке возрастания: {myMethod(x, y, z)}");

                //Finish:
                Console.WriteLine("Нажмите ESC чтобы выйти");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            //для выхода нажать ескейп :)
        }
    }
}
