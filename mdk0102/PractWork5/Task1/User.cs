using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        private string login;
        private string password;
        public delegate void ChangeHandler(string value);
        public event ChangeHandler OnChange;

        public string Login
        {
            get => login; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    OnChange?.Invoke("Невозможно изменить логин на пустую строку");
                }
                else
                {
                    login = value;
                    OnChange?.Invoke($"Логин изменен на {value}");
                }
            }
        }

        public string Password
        {
            get => password; 
            set
            {
                if (value.Length < 6 || value.Length > 20)
                {
                    OnChange?.Invoke("Длина пароля должна быть от 6 до 20 символов");
                }
                else
                {
                    password = value;
                    OnChange?.Invoke($"Пароль изменен на {value}");
                }
            }
        }
    }
}
