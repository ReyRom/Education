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

        private void MainForm_Load(object sender, EventArgs e)
        {
            ImagePictureBox.Image = Properties.Resources.Image;
            FileTextBox.Text = Properties.Resources.LoremIpsum;
            HtmlWebBrowser.DocumentText = Properties.Resources.lorem_ipsum;
            TextLabel.Text = Properties.Resources.Hello;
        }
    }
}
