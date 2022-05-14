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

        private void ToShowButton_Click(object sender, EventArgs e)
        {
            new ShowForm().ShowDialog();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            new ProductForm().ShowDialog();
        }

        private void ProducersButton_Click(object sender, EventArgs e)
        {
            new ProducersForm().ShowDialog();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            new CustomersForm().ShowDialog();
        }
    }
}
