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
    public partial class ProductsPriceForm : Form
    {
        public ProductsPriceForm()
        {
            InitializeComponent();
        }

        private void ProductsPrice_Load(object sender, EventArgs e)
        {
            LoadData();
            MinNumericUpDown.Value = MinNumericUpDown.Minimum;
            MaxNumericUpDown.Value = MaxNumericUpDown.Maximum;
        }

        void LoadData()
        {
            var products = Core.Context.Products.ToList();

            MinNumericUpDown.Minimum = MaxNumericUpDown.Minimum = products.Min(p => p.Price);
            MinNumericUpDown.Maximum = MaxNumericUpDown.Maximum = products.Max(p => p.Price);

            var filtred = products.Where(p => p.Price >= MinNumericUpDown.Value && p.Price <= MaxNumericUpDown.Value).ToList();

            ProductsDataGridView.DataSource = filtred;
        }

        private void MaxMinNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
