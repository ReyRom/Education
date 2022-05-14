using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.OnChange += User_Change;
            user.Login = "Waid";
            user.Password = "123";

        }

        private static void User_Change(object sender, DataEventArgs e)
        {
            Console.WriteLine($"{e.Date}: у пользователя {((User)sender).Login} изменено свойство {e.Parameter}");
        }
    }
}
