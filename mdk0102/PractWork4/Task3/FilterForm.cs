using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class FilterForm : Form
    {
        public delegate void DataSender(string value);
        public DataSender dataSender;
        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            dataSender?.Invoke(FilterTextBox.Text);
        }
    }
}
