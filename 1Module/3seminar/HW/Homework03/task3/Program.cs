using System;

namespace CW3
{
    /*Написать метод, вычисляющий логическое значение функции G=F(X,Y).
    * Результат равен true, если точка с координатами (X,Y) попадает в фигуру G, и результат равен false,
    * если точка с координатами (X,Y) не попадает в фигуру G.
    * Фигура G - сектор круга радиусом R=2 в диапазоне углов -90<= fi <=45.
    */
    class Program
    {

        static bool RadiusCheckerF(double x, double y)
        {
            double radians = Math.Atan2(x, y); //используем тангенс углов.

            //возвращаем тру или фолс при выполнении условий.
            return ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 4) && (-0.5 * Math.PI <= radians || radians <= Math.PI * 0.25));
        }
        static void Main(string[] args)
        {
            double x, y;
           
                Console.WriteLine("Введите x и y");

                //ловим исключения.
                while (!double.TryParse(Console.ReadLine(), out x) || !double.TryParse(Console.ReadLine(), out y)) 
                {
                    Console.WriteLine("incorrect input");
                }

                Console.WriteLine($"Ответ: {RadiusCheckerF(x, y)}"); //выводим метод.
        }
    }
}
