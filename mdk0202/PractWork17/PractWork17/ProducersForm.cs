using PractWork17.Entities;
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
    public partial class ProducersForm : Form
    {
        public ProducersForm()
        {
            InitializeComponent();
        }

        private void ProducersForm_Load(object sender, EventArgs e)
        {
            var list = Core.Context.Producers.ToList();
            list.Insert(0, new Producer() { Name = "Все Производители" });
            ProducersComboBox.DataSource = list;
            ProducersComboBox.DisplayMember = "Name";
            LoadData();
        }
        private void RenewEvent_Cause(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = Core.Context.Products.ToList();
            if (ProducersComboBox.SelectedIndex > 0)
            {
                data = data.Where(d => d.Producer == (ProducersComboBox.SelectedItem as Producer)).ToList();
            }
            ProductsDataGridView.DataSource = data;
        }
    }
}
