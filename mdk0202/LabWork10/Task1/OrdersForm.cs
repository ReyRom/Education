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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ordersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shopDataSet);
                MessageBox.Show("Сохранение успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Fill(this.shopDataSet.Products);
                this.customersTableAdapter.Fill(this.shopDataSet.Customers);
                this.orderContentsTableAdapter.Fill(this.shopDataSet.OrderContents);
                this.ordersTableAdapter.Fill(this.shopDataSet.Orders);
                MessageBox.Show("Данные загружены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void orderContentsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void idOrderLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
