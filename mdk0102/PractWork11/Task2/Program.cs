using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\s{2,}");
            Console.WriteLine("Введите строку");
            var currentString = Console.ReadLine();
            Console.WriteLine(regex.Replace(currentString, " "));
        }
    }
}
