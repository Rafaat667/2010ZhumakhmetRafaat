using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    class Program
    {

        /* 
        Выделение отдельных цифр натурального числа

        Задача. 
        Ввести трехзначное натуральное число и напечатать его цифры "столбиком".
        */

        static void Main(string[] args)
        {
            do
            {
                int number, sotaya, desyataya, posl;

                Console.WriteLine("введите трехзначное число");
                while (!int.TryParse(Console.ReadLine(), out number) | number > 999 | number < 100)  //если ввод некорректный
                {
                    Console.WriteLine("Ошибка при вводе!");                                          //альтернатива do while
                    goto finish;
                }

                sotaya = number / 100;
                desyataya = (number - (100 * sotaya)) / 10;
                posl = number - (100 * sotaya) - (10 * desyataya);

                Console.WriteLine(sotaya);
                Console.WriteLine(desyataya);
                Console.WriteLine(posl);          //альтернатива, сделать этот вывод методом

                finish:
                Console.WriteLine("для выхода нажмите ESC");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//для выхода эскейп :)
        }
    }
}
