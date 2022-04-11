using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    class User
    {
        private int id;
        private string login;
        private string password;

        public int Id
        {
            get => id; 
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException("Идентификатор должен быть положительным");
                }
            }
        }
        public string Login
        {
            get => login; 
            set
            {
                if (value.Length >= 1 && value.Length <= 30)
                {
                    login = value;
                }
                else
                {
                    throw new StringArgumentException(value, 1, 30);
                }
            }
        }
        public string Password
        {
            get => password; 
            set
            {
                if (value.Length <= 20)
                {
                    password = value;
                }
                else
                {
                    throw new StringArgumentException(value, 0, 20);
                }
            }
        }
    }
}
