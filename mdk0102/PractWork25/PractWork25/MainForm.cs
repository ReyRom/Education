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
    public partial class MainForm : StyleForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TablesButton_Click(object sender, EventArgs e)
        {
            OpenForm(new TablesForm());
        }

        private void OpenForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = TitleLabel.Text = "Главная";
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            OpenForm(new RegistrationForm());
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            OpenForm(new AuthorizationForm());
        }
    }
}
