using System;

namespace Практическая__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void First()
            {
                int number = 1;
                Random random = new Random();
                int barier = random.Next(101);
                Console.WriteLine("Вы выбрали - Угадай число");
                while (true)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < barier)
                    {
                        Console.WriteLine("Загаданное число больше");
                    }
                    if (number > barier)
                    {
                        Console.WriteLine("Загаданное число меньше");
                    }
                    if (number == barier)
                    {
                        Console.WriteLine("Вы угадали!");
                        break;
                    }
                }
            }
            static void Second()
            {
                var table = new int[10, 10];
                for (int i = 0; i < 10; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        table[i, j] = i * j;
                    }
                }
                for (int i = 0; i < 10; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        Console.Write("{0, 3}", table[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            static void Third()
            {
                Console.WriteLine("Введите число: ");
                float number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= number; ++i)
                {
                    if (number % i == 0) 
                    {
                        if (number != i / number) Console.Write("{0} {1} ", number, i / number);
                        else Console.Write("{0} ", number);
                    }
                }
            }

                Console.WriteLine("Выберите программу: ");
            Console.WriteLine("1) Угадай число");
            Console.WriteLine("2) Таблица");
            Console.WriteLine("3) Вывод делителей числа");
            Console.WriteLine("4) Выход");
            Console.ReadLine();
            int input = Convert.ToInt32(Console.ReadLine());
            while (input != 4)
            {
                if (input == 1)
                {
                    First();
                }
                if (input == 2)
                {
                    Second();
                }
                if (input == 3)
                {
                    Third();
                }
                if (input == 4)
                {
                    break;
                }
                Console.WriteLine("Выберите программу: ");
                Console.WriteLine("1) Угадай число");
                Console.WriteLine("2) Таблица");
                Console.WriteLine("3) Вывод делителей числа");
                Console.WriteLine("4) Выход");
                input = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}