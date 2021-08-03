using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string sname = Console.ReadLine();
            Console.WriteLine("Введите город: ");
            string city = Console.ReadLine();
                                                              
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2); // свавим в центр окна
            Console.WriteLine("Имя: {0} Фамилия: {1} город {2}", name, sname, city);
        }
    }
}
