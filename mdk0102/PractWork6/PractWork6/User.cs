using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PractWork6
{
    public class User : INotifyPropertyChanged
    {
        private string login;
        private string password;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Login
        {
            get => login; 
            set
            {
                login = value;
                NotifyPropertyChanged();
            }
        }
        public string Password
        {
            get => password; 
            set
            {
                password = value;
                NotifyPropertyChanged();
            }
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
