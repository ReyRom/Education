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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["Login"].Value = LoginTextBox.Text;
            configuration.AppSettings.Settings["Password"].Value = PasswordTextBox.Text;
            configuration.AppSettings.Settings["DataBase"].Value = DataBaseTextBox.Text;
            configuration.Save();
            
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Настройки сохранены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoginTextBox.Text = ConfigurationManager.AppSettings.Get("Login");
            PasswordTextBox.Text = ConfigurationManager.AppSettings.Get("Password");
            DataBaseTextBox.Text = ConfigurationManager.AppSettings.Get("DataBase");
        }
    }
}
