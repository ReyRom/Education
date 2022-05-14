using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class User
    {
        private string login;
        private string password;
        public event EventHandler OnChange;

        public string Login
        {
            get => login; set
            {
                login = value;
                OnChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public string Password
        {
            get => password; set
            {
                password = value;
                OnChange?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
