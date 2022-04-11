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
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
        }

        private void RenewEvent_Cause(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = Core.Context.Orders.ToList();
            if (OrdersDateTimePicker.Checked)
            {
                data = data.Where(o =>o.DateOfOrder.Month == OrdersDateTimePicker.Value.Month && o.DateOfOrder.Year == OrdersDateTimePicker.Value.Year).ToList();
            }
            
            OrdersDataGridView.DataSource = data;
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
