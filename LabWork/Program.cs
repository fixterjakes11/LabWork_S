using System;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод цифр от натурального числа.\nНажмите Enter...");
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    try
                    {
                        Console.Write("Введите число: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат: {count(x)} ");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введите число");
                    }
                }
                else
                {
                    break;
                }

            }
        }

        static string count(int n)
        {
            
            if (n > 10)
            {
                return $"{count(n / 10)} { n % 10 }";
            }
            return $"{n}";

        }

    }
}
