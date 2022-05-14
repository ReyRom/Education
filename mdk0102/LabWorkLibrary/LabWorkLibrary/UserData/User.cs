using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkLibrary.UserData
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        private int id;
        private string login;
        private string password;
        private bool isPriveleged;

        /// <summary>
        /// Свойство для досутпа к полю логин
        /// </summary>
        public string Login
        {
            get => login; 
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    login = value;
                }
            }
        }

        /// <summary>
        /// Смена пароля
        /// </summary>
        /// <param name="password">Новый пароль</param>
        /// <returns>Удалось ли изменить пароль</returns>
        public bool ChangePassword(string password) 
        {
            if (this.password == password || String.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            else
            {
                this.password = password;
                return true;
            }
        }

        /// <summary>
        /// Изменение уровня привелегий
        /// </summary>
        /// <param name="role">Роль пользователя</param>
        public void ChangePriveleged(Role role)
        {
            isPriveleged = role == Role.Administrator;
        }
    }
}
