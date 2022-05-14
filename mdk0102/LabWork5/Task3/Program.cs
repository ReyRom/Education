using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var currentString = Console.ReadLine().Trim();
            var list = currentString.Split(new char[] { ',', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
