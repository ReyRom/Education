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
    public partial class ProducersForm : Form
    {
        public ProducersForm()
        {
            InitializeComponent();
        }

        private void producersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.producersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shopDataSet);
                MessageBox.Show("Сохранение успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProducersForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.producersTableAdapter.Fill(this.shopDataSet.Producers);
                MessageBox.Show("Данные загружены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
