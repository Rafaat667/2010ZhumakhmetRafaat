using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        public static void reverseNumber(int a)
        {
            string word = a.ToString();
            char[] array = word.ToCharArray();
            Array.Reverse(array);
            word = new string(array);
            int newA = int.Parse(word);

            Console.WriteLine(newA);
        }
        
        static void Main(string[] args)
        {
            int a;
            string input = Console.ReadLine();

            while (!int.TryParse(input, out a))
            {
                Console.WriteLine("incorrect input");
                goto Finish;
            }

            Finish:
            reverseNumber(a);
        }
    }
}
