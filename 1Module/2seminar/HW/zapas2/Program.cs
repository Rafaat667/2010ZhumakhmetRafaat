using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapas2
{
    class Program
    {
        public static string myMethod(int n1, int n2, int n3)
        {
            string a;

            return a = n1 > n2 ? (n2 > n3 ? $"{n1},{n2},{n3}" : (n1 > n3 ? $"{n1},{n3},{n2}" : $"{n3},{n1},{n2}")) : (n1 > n3 ? $"{n2},{n1},{n3}" : (n2 > n3 ? $"{n2},{n3},{n1}" : $"{n3},{n2},{n1}"));
        }
        static void Main(string[] args)
        {
            int n1, n2, n3;
            string vv1, vv2, vv3;

            Console.WriteLine("Введите три числа");

            vv1 = Console.ReadLine();
            vv2 = Console.ReadLine();
            vv3 = Console.ReadLine();

            if (!((int.TryParse(vv1, out n1)) || (int.TryParse(vv2, out n2)) || (int.TryParse(vv3, out n3))))
            {
                Console.WriteLine("ошибка при вводе");
            }

            n1 = int.Parse(vv1);
            n2 = int.Parse(vv2);
            n3 = int.Parse(vv3);


            Console.WriteLine(myMethod(n1, n2, n3));
        }
    }
}
