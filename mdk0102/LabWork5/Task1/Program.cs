using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var currentString = Console.ReadLine();
            Console.WriteLine($"Количество символов: {currentString.Length} \nБез пробелов: {currentString.Replace(" ", String.Empty).Length}");
        }
    }
}
