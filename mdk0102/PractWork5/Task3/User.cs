using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class User
    {
        private string login;
        private string password;
        public event EventHandler<DataEventArgs> OnChange;

        public string Login
        {
            get => login; 
            set
            {
                login = value;
                DataEventArgs eventArgs = new DataEventArgs
                {
                    Parameter = "логин",
                    Date = DateTime.Now
                };
                OnChange?.Invoke(this, eventArgs);
            }
        }

        public string Password
        {
            get => password; 
            set
            {
                password = value;
                DataEventArgs eventArgs = new DataEventArgs
                {
                    Parameter = "пароль",
                    Date = DateTime.Now
                };
                OnChange?.Invoke(this, eventArgs);
            }
        }
    }
}
