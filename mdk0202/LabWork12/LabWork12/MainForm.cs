using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork12
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            new UsersTableForm().Show();
        }

        private void UsersDetailsButton_Click(object sender, EventArgs e)
        {
            new UsersDetailsForm().Show();
        }
    }
}
