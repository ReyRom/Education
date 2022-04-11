using System;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?i)^[a-z0-9-_]+@([a-zа-я0-9]+\.)+[a-zа-я]+$");
            Console.WriteLine("Введите строку");
            var email = Console.ReadLine();
            if (regex.IsMatch(email))
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
