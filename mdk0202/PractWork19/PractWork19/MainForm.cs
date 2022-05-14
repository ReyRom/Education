using PractWork19.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork19
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> rows = new List<Product>();
                foreach (DataGridViewRow item in ProductsDataGridView.SelectedRows)
                {
                    rows.Add((Product)item.DataBoundItem);
                }
                if (MessageBox.Show($"Вы уверены, что хотите удалить {rows.Count} записей?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Core.Context.Products.RemoveRange(rows);
                    Core.Context.SaveChanges();
                    MessageBox.Show($"Данные успешно удалены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось удалить записи.Причина: { ex.Message}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            ProductsDataGridView.DataSource = Core.Context.Products.Where(p => !p.IsDeleted).ToList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new ProductForm().ShowDialog();
            LoadData();
        }

        private void ProductsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product product = (Product)ProductsDataGridView.Rows[e.RowIndex].DataBoundItem;
            new ProductForm(product).ShowDialog();
            LoadData();
        }
    }
}
