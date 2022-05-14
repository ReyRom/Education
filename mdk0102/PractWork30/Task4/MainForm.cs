using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenAuthButton_Click(object sender, EventArgs e)
        {
            if (new AuthForm().ShowDialog() == DialogResult.OK)
            {
                new SettingsForm().ShowDialog();
            }
        }
    }
}
