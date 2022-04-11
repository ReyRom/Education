using System;

namespace Task1
{
    class Program
    {
        public delegate int Mathematics(int value);

        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Mathematics mathematics = Square;
            Console.WriteLine(mathematics?.Invoke(-5));
            mathematics = Abs;
            Console.WriteLine(mathematics?.Invoke(-5));
            mathematics = Factorial;
            Console.WriteLine(mathematics?.Invoke(5));

            Console.WriteLine("\nTask4");

            Mathematics[] math = { Square, Abs, Factorial };
            foreach (var item in math)
            {
                Console.WriteLine(item.Invoke(8));
            }

            Console.WriteLine("\nTask5");

            foreach (var item in math)
            {
                CallDelegate(item, 3);
            }
        }

        public static int Square(int value)
        {
            return value * value;
        }

        public static int Abs(int value)
        {
            if (value < 0)
            {
                return -value;
            }
            return value;
        }

        public static int Factorial(int value)
        {
            if (value < 0)
            {
                return -1;
            }
            if (value == 0)
            {
                return 1;
            }
            return value * Factorial(value-1);
        }

        public static void CallDelegate(Mathematics math, int value)
        {
            Console.WriteLine(math.Invoke(value));
        }
    }
}
