using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork16.Task3
{
    public partial class CustomersListForm : Form
    {
        public CustomersListForm()
        {
            InitializeComponent();
        }

        private void CustomersListForm_Load(object sender, EventArgs e)
        {
            var data = Core.Context.Customers.ToList();
            CustomerDataGridView.DataSource = data.OrderBy(c => c.Login, StringComparer.Ordinal).ToList();
        }
    }
}
