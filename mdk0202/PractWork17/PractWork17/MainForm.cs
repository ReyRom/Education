using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork17
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            new ModelForm().Show();
        }

        private void ProductsPriceButton_Click(object sender, EventArgs e)
        {
            new PriceForm().Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            new DateForm().Show();
        }

        private void ProducersButton_Click(object sender, EventArgs e)
        {
            new ProducersForm().Show();
        }
    }
}
