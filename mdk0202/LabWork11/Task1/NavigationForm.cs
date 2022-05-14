using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            new CustomersForm().ShowDialog();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            new AddProductForm().ShowDialog();
        }
    }
}
