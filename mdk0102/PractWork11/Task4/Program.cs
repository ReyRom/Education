using System;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[.!?]).{6,}$");
            Console.WriteLine("введите пароль");
            var pass = Console.ReadLine();
            if (regex.IsMatch(pass))
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
