using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Sample
    {
        /// <summary>
        /// Вычисление результата деления
        /// </summary>
        /// <param name="a">делимое</param>
        /// <param name="b">делитель</param>
        /// <returns></returns>
        public static double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();   
            }
            return a / b;
        }
        /// <summary>
        /// Проверка возможности регистрации пользователя
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <param name="confirm">подтверждение</param>
        /// <returns></returns>
        public static bool Check(string login, string password, string confirm)
        {
            return false;
        }
    }
}
