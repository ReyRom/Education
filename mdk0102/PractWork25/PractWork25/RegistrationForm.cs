using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork25
{
    public partial class RegistrationForm : DialogForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        protected override void ProcessData()
        {
            base.ProcessData();
            if (!String.IsNullOrWhiteSpace(LoginTextBox.Text) 
                && !String.IsNullOrWhiteSpace(PasswordTextBox.Text) 
                && PasswordTextBox.Text == ConfirmTextBox.Text)
            {
                MessageBox.Show("Успешная регистрация", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не удалось зарегистрироваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Text = TitleLabel.Text = "Регистрация";
        }
    }
}
