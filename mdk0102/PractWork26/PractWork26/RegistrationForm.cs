using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork26
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (String.IsNullOrWhiteSpace(LoginTextBox.Text)) 
                stringBuilder.Append("Не заполнен логин\n");
            if (String.IsNullOrWhiteSpace(EmailTextBox.Text)) 
                stringBuilder.Append("Не заполнен email\n");
            if (PasswordTextBox.Text != ConfirmTextBox.Text) 
                stringBuilder.Append("Не совпадают пароль и подтверждение\n");

            if (stringBuilder.Length == 0)
            {
                MessageBox.Show($"Добро пожаловать, {LoginTextBox.Text}!\n Вы успешно зарегистрированы", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(stringBuilder.ToString(), "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginTextBox_Validating(object sender, CancelEventArgs e)
        {
            LoginErrorProvider.Clear();
            StringBuilder stringBuilder = new StringBuilder();
            if (String.IsNullOrWhiteSpace(LoginTextBox.Text)) 
                stringBuilder.Append("Логин не введен\n");
            if (LoginTextBox.Text.Trim().Length < 3) 
                stringBuilder.Append("Длина логина менее трех символов\n");
            if (stringBuilder.Length > 0)
            {
                LoginErrorProvider.SetError(LoginTextBox, stringBuilder.ToString());
            }
        }

        private void AgeTextBox_Validating(object sender, CancelEventArgs e)
        {
            AgeErrorProvider.Clear();
            StringBuilder stringBuilder = new StringBuilder();
            if (String.IsNullOrWhiteSpace(AgeTextBox.Text)) 
                stringBuilder.Append("Не указан возраст\n");
            int value;
            if (!Int32.TryParse(AgeTextBox.Text, out value) && value <= 0) 
                stringBuilder.Append("Указан некорректный возраст\n");
            if (stringBuilder.Length > 0)
            {
                AgeErrorProvider.SetError(AgeTextBox, stringBuilder.ToString());
            }
        }

        private void PasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            PasswordErrorProvider.Clear();
            StringBuilder stringBuilder = new StringBuilder();
            if (String.IsNullOrWhiteSpace(PasswordTextBox.Text)) 
                stringBuilder.Append("Пароль не введен\n");
            if (PasswordTextBox.Text.Trim().Length < 5) 
                stringBuilder.Append("Длина пароля менее пяти символов\n");
            if (!PasswordTextBox.Text.Any(Char.IsDigit)) 
                stringBuilder.Append("Пароль не содержит цифру\n");
            if (!PasswordTextBox.Text.Any(Char.IsLower)) 
                stringBuilder.Append("Пароль не содержит маленькую букву\n");
            if (!PasswordTextBox.Text.Any(Char.IsUpper)) 
                stringBuilder.Append("Пароль не содержит большую букву\n");
            if (stringBuilder.Length > 0)
            {
                PasswordErrorProvider.SetError(PasswordTextBox, stringBuilder.ToString());
            }
        }

        private void EmailTextBox_Validating(object sender, CancelEventArgs e)
        {
            EmailErrorProvider.Clear();
            Regex regex = new Regex(@"^[A-Za-z0-9]{3,}\@(\w+\.)+(\w+)$");
            if (!regex.IsMatch(EmailTextBox.Text))
            {
                EmailErrorProvider.SetError(EmailTextBox, "Неверный e-mail");
            }
        }
    }
}
