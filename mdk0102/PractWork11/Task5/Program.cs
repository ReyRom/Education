using System;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b((?<day>\d{1,2})\.(?<month>\d{1,2})\.(?<year>\d{4}|\d{2})|(?<day>\d{1,2})\/(?<month>\d{1,2})\/(?<year>\d{4}|\d{2}))\b");
            var replace = @"${year}-${month}-${day}";
            Console.WriteLine("введите дату");
            var date = Console.ReadLine();
            Console.WriteLine(regex.Replace(date, replace));
        }
    }
}
