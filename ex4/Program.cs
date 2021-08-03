using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            Console.Write("Введите первое целое число x: "); 
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число y: "); 
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("число х= {0} число у= {1}", num1, num2);
            int x = num1;                   //присваиваем num1 к х
            num1 = num2;                    //присваиваем num1 к num2
            num2 = x;                       // присваиваем х к num2
            Console.WriteLine("число х= {0} число у= {1}", num1, num2);
        }
    }
}
