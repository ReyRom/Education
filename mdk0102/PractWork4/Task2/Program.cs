using System;

namespace Task2
{
    class Program
    {
        public delegate void Mathematics(int a, int b);
        static void Main(string[] args)
        {
            Mathematics mathematics = Add;
            mathematics += Subtract;
            mathematics += Divide;
            mathematics += Multiply;

            mathematics?.Invoke(3, 2);
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Divide(int a, int b)
        {
            if (b==0)
            {
                Console.WriteLine("Деление на ноль");
            }
            else
            {
                Console.WriteLine(a / b);
            }
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
