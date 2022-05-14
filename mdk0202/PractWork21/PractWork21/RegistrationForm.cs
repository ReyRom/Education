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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
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
            if (user != null)
            {
                user = null;
                MessageBox.Show("Введеный логин занят", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PasswordTextBox.Text != ConfirmTextBox.Text)
            {
                MessageBox.Show("Пароль и подтверждение не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var defaultRole = Core.Context.UserRoles.FirstOrDefault(x => x.Name == "Покупатель");
            Core.Context.Users.Add(new User() { Login = LoginTextBox.Text, Password = PasswordTextBox.Text, UserRole = defaultRole });
            Core.Context.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрированы", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
