using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три слоав");

            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();

            Console.WriteLine($"-{word1}-");
            Console.WriteLine($"-{word2}-");
            Console.WriteLine($"-{word3}-");
        }
    }
}
