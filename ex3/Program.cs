using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая подсчитывает расстояние между точками
            Console.Write("Введите x точки А: "); 
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y точки А: "); 
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x точки B: "); 
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y точки B: "); 
            int y2 = Convert.ToInt32(Console.ReadLine());

            var r = Math.Sqrt(Math.Pow(x2 - x2, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками A и B {0:F2}", r);  //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        }
    }
}
