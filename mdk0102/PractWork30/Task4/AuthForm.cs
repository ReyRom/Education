using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == ConfigurationManager.AppSettings.Get("Login") && PasswordTextBox.Text == ConfigurationManager.AppSettings.Get("Password"))
            {
                MessageBox.Show("Вы успешно авторизовались", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Не удалось авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
