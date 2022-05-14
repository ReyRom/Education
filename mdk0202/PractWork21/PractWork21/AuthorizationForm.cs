using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork21
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var user = Core.Context.Users.AsNoTracking().FirstOrDefault(u => u.Login.ToLower() == LoginTextBox.Text.ToLower());
            if (user == null || user.Password != PasswordTextBox.Text)
            {
                user = null;
                MessageBox.Show("Введены некорректные данные. Повторите ввод.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Connection.CurrentUser = user;
            MessageBox.Show("Добро пожаловать.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void RegistrationBbutton_Click(object sender, EventArgs e)
        {
            new RegistrationForm().ShowDialog();
        }
    }
}
