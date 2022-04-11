using PractWork16.Task1;
using PractWork16.Task2;
using PractWork16.Task3;
using PractWork16.Task4;
using PractWork16.Task5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork16
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CustomerLoginButton_Click(object sender, EventArgs e)
        {
            new CustomerLoginForm().Show();
        }

        private void ProductsPriceDescButton_Click(object sender, EventArgs e)
        {
            new ProductsPriceDescForm().Show();
        }

        private void OrdersDateDescButton_Click(object sender, EventArgs e)
        {
            new OrdersDateDescForm().Show();
        }

        private void ProductsPriceTypeButton_Click(object sender, EventArgs e)
        {
            new ProductsPriceTypeForm().Show();
        }

        private void ProductsTypePriceDescButton_Click(object sender, EventArgs e)
        {
            new ProductsTypePriceDescForm().Show();
        }

        private void ProductsProducerModelButton_Click(object sender, EventArgs e)
        {
            new ProductsProducerModelForm().Show();
        }

        private void CustomersListButton_Click(object sender, EventArgs e)
        {
            new CustomersListForm().Show();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            new ProductsForm().Show();
        }

        private void ProductsMultiSortButton_Click(object sender, EventArgs e)
        {
            new ProductsMultiSortForm().Show();
        }
    }
}
