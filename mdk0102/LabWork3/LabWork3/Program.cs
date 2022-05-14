using System;
using LabWorkLibrary;
using LabWorkLibrary.UserData;

namespace LabWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maths.PI);
            Console.WriteLine(Maths.Add(1, 9));
            Console.WriteLine(Maths.Div(1, 9));
            Console.WriteLine(Maths.Mul(1, 9));
            Console.WriteLine(Maths.Sub(9, 9));
            User user = new User();
            user.ChangePassword("123");
            Console.WriteLine(user.ChangePassword("123").ToString());
            Console.WriteLine(user.Login = "123");
        }
    }
}
