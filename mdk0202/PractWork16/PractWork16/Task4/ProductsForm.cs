using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork16.Task4
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void PriceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            var data = Core.Context.Products.ToList();
            if (PriceRadioButton.Checked)
            {
                data = data.OrderBy(p => p.Price).ToList();
            }
            else
            {
                data = data.OrderByDescending(p => p.Price).ToList();
            }
            ProductsDataGridView.DataSource = data;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
