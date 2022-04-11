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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void OpenForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void ProducersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new ProducersForm());
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomersForm());
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new OrdersForm());
        }
    }
}
