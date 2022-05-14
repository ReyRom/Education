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
    public partial class ProductsTypesForm : Form
    {
        public ProductsTypesForm()
        {
            InitializeComponent();
        }

        private void ProductsTypesForm_Load(object sender, EventArgs e)
        {
            ProductsDataGridView.DataSource = Core.Context.Products.GroupBy(p => p.Type)
                .Select(gr => new { Type = gr.Key, Count = gr.Count(), Avg = gr.Average(p => p.Price) }).ToList();
        }
    }
}
