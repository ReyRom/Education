using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork18
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProductsPriceButton_Click(object sender, EventArgs e)
        {
            new ProductsPriceForm().Show();
        }

        private void ProducersButton_Click(object sender, EventArgs e)
        {
            new ProducersForm().Show();
        }

        private void OrdersSumButton_Click(object sender, EventArgs e)
        {
            new OrdersSumForm().Show();
        }

        private void ProductsTypesButton_Click(object sender, EventArgs e)
        {
            new ProductsTypesForm().Show();
        }

        private void OrderProductsButton_Click(object sender, EventArgs e)
        {
            new OrderProductsForm().Show();
        }
    }
}
