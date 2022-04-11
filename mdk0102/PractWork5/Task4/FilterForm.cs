using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class FilterForm : Form
    {
        public delegate void ChangeHandler(string value);
        public event ChangeHandler OnFilterChange;
        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            OnFilterChange?.Invoke(FilterTextBox.Text);
        }
    }
}
