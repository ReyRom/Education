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
    public partial class AuthorizationForm : DialogForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            Text = TitleLabel.Text = "Авторизация";
        }
        protected override void ProcessData()
        {
            base.ProcessData();
            if (!String.IsNullOrWhiteSpace(LoginTextBox.Text) && !String.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Успешная авторизация", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не удалось авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
