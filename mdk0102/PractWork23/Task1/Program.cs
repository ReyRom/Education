using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine(context.ExecuteStrategy(5, 10));

            context = new Context(new OperationMultiply());
            Console.WriteLine(context.ExecuteStrategy(5, 10));
        }
    }
}
