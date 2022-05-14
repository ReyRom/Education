using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork16.Task5
{
    public partial class ProductsMultiSortForm : Form
    {
        public ProductsMultiSortForm()
        {
            InitializeComponent();
        }

        private void ProductsMultiSortForm_Load(object sender, EventArgs e)
        {
            var array = new string[] { "-", "Type", "Price", "Year" };
            comboBox1.Items.AddRange(array);
            comboBox2.Items.AddRange(array);
            comboBox3.Items.AddRange(array);
            LoadData();
        }
        void LoadData()
        {
            var data = Core.Context.Products.ToList();
            if (checkBox1.Checked)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 1:
                        data = data.OrderBy(x => x.Type).ToList();
                        break;
                    case 2:
                        data = data.OrderBy(x => x.Price).ToList();
                        break;
                    case 3:
                        data = data.OrderBy(x => x.Year).ToList();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 1:
                        data = data.OrderByDescending(x => x.Type).ToList();
                        break;
                    case 2:
                        data = data.OrderByDescending(x => x.Price).ToList();
                        break;
                    case 3:
                        data = data.OrderByDescending(x => x.Year).ToList();
                        break;
                    default:
                        break;
                }
            }
            ProductsDataGridView.DataSource = data;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
