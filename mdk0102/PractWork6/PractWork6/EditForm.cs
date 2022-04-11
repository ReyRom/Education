using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork6
{
    public partial class EditForm : Form
    {
        User currentUser;
        public EditForm(User user)
        {
            InitializeComponent();

            currentUser = user;
            LoginTextBox.Text = currentUser.Login;
            PasswordTextBox.Text = currentUser.Password;
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentUser.Login != LoginTextBox.Text)
            {
                currentUser.Login = LoginTextBox.Text;
            }
            if (currentUser.Password != PasswordTextBox.Text)
            {
                currentUser.Password = PasswordTextBox.Text;
            }
        }
    }
}
