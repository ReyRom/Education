using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.OnChange += User_Change;

            user.Login = "123";
            user.Password = "12341212";
            user.Login = "";
            user.Password = "123";
        }

        private static void User_Change(string value)
        {
            Console.WriteLine(value);
        }
    }
}
