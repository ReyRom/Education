using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var findString = Console.ReadLine();
            var array = new string[]
            {
                "доброе утро рома",
                "доброе утро илья",
                "доброе утро маша",
                "доброе утро даша",
                "доброе утро саша",
                "доброе утро паша",
                "доброе утро ваша",
                "доброе утро рома",
                "доброе утро рома",
                "доброе утро рома",
                "доброе утро рома",
                "Маломан - лучший преподаватель",
                "доброе утро рома",
                "доброе утро рома",
                "доброе утро рома",
                "доброе утро рома",
            };
            string printString = "";
            foreach (var item in array)
            {
                if (item.Contains(findString))
                {
                    printString = printString.Insert(printString.Length, item + "\n"); ;
                }
            }
            if (printString.Length != 0)
            {
                Console.WriteLine(printString);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}
