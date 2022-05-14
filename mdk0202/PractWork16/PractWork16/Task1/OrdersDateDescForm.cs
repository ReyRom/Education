using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork16.Task1
{
    public partial class OrdersDateDescForm : Form
    {
        public OrdersDateDescForm()
        {
            InitializeComponent();
        }

        private void OrdersDateDescForm_Load(object sender, EventArgs e)
        {
            OrdersDataGridView.DataSource = Core.Context.Orders.OrderByDescending(o => o.DateOfOrder).ToList();
        }
    }
}
