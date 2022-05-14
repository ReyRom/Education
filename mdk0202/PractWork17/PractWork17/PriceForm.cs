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
    public partial class PriceForm : Form
    {
        public PriceForm()
        {
            InitializeComponent();
        }
        private void RenewEvent_Cause(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = Core.Context.Products.ToList();
            decimal min;
            decimal max;
            if (Decimal.TryParse(MinTextBox.Text, out min))
            {
                data = data.Where(d => d.Price >= min).ToList();
            }
            if (Decimal.TryParse(MaxTextBox.Text, out max))
            {
                data = data.Where(d => d.Price <= max).ToList();
            }
            ProductsDataGridView.DataSource = data;
        }
    }
}
