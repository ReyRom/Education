using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[+]7[(]9\d{2}[)]\d{3}[-]\d{2}[-]\d{2}$");
            Console.WriteLine("введите номер");
            var phone = Console.ReadLine();
            if (regex.IsMatch(phone))
            {
                Console.WriteLine("корректно");
            }
            else
            {
                Console.WriteLine("некорректно");
            }
        }
    }
}
