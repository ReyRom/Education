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
    public partial class OrdersSumForm : Form
    {
        public OrdersSumForm()
        {
            InitializeComponent();
        }

        private void OrdersSumForm_Load(object sender, EventArgs e)
        {
            var list = Core.Context.Orders.ToList();
            OrdersDataGridView.DataSource = list.Select(o => new
            {
                o.IdOrder,
                o.DateOfOrder,
                o.Customer.Login,
                Cost = (o.OrderContents?.Sum(x => x.Product.Price * x.Quantity) ?? 0)
            }).ToList();
        }
    }
}
