using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork16.Task2
{
    public partial class ProductsPriceTypeForm : Form
    {
        public ProductsPriceTypeForm()
        {
            InitializeComponent();
        }

        private void ProductsPriceTypeForm_Load(object sender, EventArgs e)
        {
            ProductsDataGridView.DataSource = Core.Context.Products.OrderBy(p => p.Type).ThenBy(p => p.Price).ToList();
        }
    }
}
