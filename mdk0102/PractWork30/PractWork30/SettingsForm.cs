using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork30
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Login = LoginTextBox.Text;
            Properties.Settings.Default.Password = PasswordTextBox.Text;
            Properties.Settings.Default.DataBase = DataBaseTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoginTextBox.Text = Properties.Settings.Default.Login;
            PasswordTextBox.Text = Properties.Settings.Default.Password;
            DataBaseTextBox.Text = Properties.Settings.Default.DataBase;
        }
    }
}
