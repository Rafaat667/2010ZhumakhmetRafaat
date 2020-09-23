using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        /*
         * Трехзначным целым числом кодируется номер аудитории в учебном корпусе. 
         * Старшая цифра обозначают номер этажа, а две младшие –  номер аудитории на этаже.
         * Из трех аудиторий определить и вывести на экран ту аудиторию,
         * которая имеет минимальный номер внутри этажа. Если таких аудиторий несколько - вывести любую из них. 
         */
        public static void auditoryIerarhy(int aud1, int aud2, int aud3)
        {
            int etazh1, etazh2, etazh3, min, min1, min2, min3;

            //узнаем этаж каждой аудитории.
            etazh1 = (aud1 - aud1 % 100) / 100;
            etazh2 = (aud2 - aud2 % 100) / 100;
            etazh3 = (aud3 - aud3 % 100) / 100;

            if (etazh1 == etazh2 && etazh2 == etazh3) //если этаж совпаает у всех.
            {
                //узнаем минимальную аудиторию.
                min = aud1 < aud2 ? (aud1 < aud3 ? aud1 : aud3) : (aud2 < aud3 ? aud2 : aud3);
                Console.WriteLine();
                Console.WriteLine(min);
            }
            else if (etazh1 == etazh2 && etazh2 != etazh3) //совпадает только 1 и 2 этаж.
            {
               //находим минимальную аудиторию на этаже 1 и 2.
                min1 = aud1 < aud2 ? aud1 : aud2;
                Console.WriteLine(); //просто оставляем место.
                Console.WriteLine(min1); //минимальное на этаже.
                Console.WriteLine(aud3); //оставшийся этаж.
            }
            else if (etazh2 == etazh3 && etazh1 != etazh2) //совпадает только 3 и 2 этаж.
            {
                //находим минимальную аудиторию на этаже 3 и 2.
                min2 = aud2 < aud3 ? aud2 : aud3;
                Console.WriteLine(); //просто оставляем место.
                Console.WriteLine(min2); //минимальное на этаже.
                Console.WriteLine(aud1); //оставшийся этаж.
            }
            else if (etazh1 == etazh3 && etazh2 != etazh1) //совпадает только 3 и 1 этаж.
            {
                //находим минимальную аудиторию на этаже 3 и 1.
                min3 = aud1 < aud3 ? aud1 : aud3;
                Console.WriteLine(); //просто оставляем место.
                Console.WriteLine(min3); //минимальное на этаже.
                Console.WriteLine(aud2); //оставшийся этаж.
            }
            else  //если никакие этажи не совпадает.
            {
                Console.WriteLine(); //просто оставляем место.
                //выводим все оставшиеся аудитории.
                Console.WriteLine(aud1);
                Console.WriteLine(aud2);
                Console.WriteLine(aud3);
            }
        }
        
        static void Main(string[] args)
        {
            int aud1,
                aud2,
                aud3;
            
            Console.WriteLine("Введите три номера аудиторий");

            //ловим исключения и ставим ограничения на трехзнаяность. 
            while (!int.TryParse(Console.ReadLine(), out aud1) || !int.TryParse(Console.ReadLine(), out aud2) || 
                   !int.TryParse(Console.ReadLine(), out aud3) || aud1<100 || aud1>999 || aud2 < 100 || aud2 > 999
                   || aud3 < 100 || aud3 > 999 || aud1 == aud2 || aud2 == aud3 || aud1 == aud3)
            {
                Console.WriteLine("Некорректный ввод");
            }
                
            auditoryIerarhy(aud1, aud2, aud3);//вывод метода.
        }
    }
}
