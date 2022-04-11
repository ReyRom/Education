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
    public partial class ProductsPriceDescForm : Form
    {
        public ProductsPriceDescForm()
        {
            InitializeComponent();
        }

        private void ProductsPriceDescForm_Load(object sender, EventArgs e)
        {
            ProductsDataGridView.DataSource = Core.Context.Products.OrderByDescending(p => p.Price).ToList();
        }
    }
}
