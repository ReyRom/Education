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
    public partial class OrderProductsForm : Form
    {
        public OrderProductsForm()
        {
            InitializeComponent();
        }

        private void OrderProductsForm_Load(object sender, EventArgs e)
        {
            var list = Core.Context.Orders.ToList();
            var selected = list.Select(o => new
            {
                o.IdOrder,
                o.DateOfOrder,
                Products = o.OrderContents.Count != 0 ? (o.OrderContents.Select(x => x.Product.Model).Aggregate((x, y) => x + ", " + y)) : "Нет содержимого"
            }).ToList();
            OrdersDataGridView.DataSource = selected;
        }
    }
}
