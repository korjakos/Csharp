using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: "); 
            string sname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            string age = Console.ReadLine();
            Console.WriteLine("Введите рост: ");
            string rost = Console.ReadLine();
            Console.WriteLine("Введите вес: ");
            string ves = Console.ReadLine();
 
            Console.WriteLine("Имя " + name + " фамилия " + sname + " возраст " + age + " рост " + rost + " вес " + ves);

            Console.WriteLine("Имя {0} Фамилия {1} возраст {2:D} рост {3:D} вест {4:D}", name, sname, age, rost, ves);  // не очень понял как тут вывести через форматированный вывод, так как ничего не меняется

            Console.WriteLine($"Имя {name} Фамилия {sname} возраст {age} рост {rost} вес {ves}");
        }
    }
}
