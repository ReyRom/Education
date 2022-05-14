using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var currentString = Console.ReadLine().Trim();
            while (currentString.Contains("  "))
            {
                currentString = currentString.Replace("  ", " ");
            }
            Console.WriteLine(currentString);
        }
    }
}
