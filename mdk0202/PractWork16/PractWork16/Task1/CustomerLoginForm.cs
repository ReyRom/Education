using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork16
{
    public partial class CustomerLoginForm : Form
    {
        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private void CustomerLoginForm_Load(object sender, EventArgs e)
        {
            CustomerDataGridView.DataSource = Core.Context.Customers.OrderBy(c => c.Login).ToList();
        }
    }
}
