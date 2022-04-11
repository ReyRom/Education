using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class CustomersForm : TableForm
    {
        public CustomersForm()
        {
            InitializeComponent();
            tableName = "Customers";
        }
    }
}
