using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост (см.): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес (кг.): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            //Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            var h = height / 100;
            var i = weight / (h * h);
            Console.WriteLine("Индекс массы тела =" + i);
        }
    }
}
