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
    public partial class ProductsProducerModelForm : Form
    {
        public ProductsProducerModelForm()
        {
            InitializeComponent();
        }

        private void ProductsProducerModelForm_Load(object sender, EventArgs e)
        {
            ProductsDataGridView.DataSource = Core.Context.Products.OrderBy(p => p.Producer.Name).ThenBy(p => p.Model).ToList();
        }
    }
}
