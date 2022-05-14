using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.OnChange += User_Change;
            user.Login = "Waid";
            user.Login = "123";

        }

        private static void User_Change(object sender, EventArgs e)
        {
            Console.WriteLine($"Изменены данные пользователя со следующим логином: {((User)sender).Login}.");
        }
    }
}
