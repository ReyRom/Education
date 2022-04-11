using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lection19032022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void producersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.producersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcs9114DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pcs9114DataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.pcs9114DataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pcs9114DataSet.Producers". При необходимости она может быть перемещена или удалена.
            this.producersTableAdapter.Fill(this.pcs9114DataSet.Producers);

        }
    }
}
