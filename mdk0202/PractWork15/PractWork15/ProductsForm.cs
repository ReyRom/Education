using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork15
{
    public partial class ProductsForm : Form
    {
        int pageSize = 5;
        int currentPage = 1;
        int totalPages;
        int countOfPages = 1;
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            PageSizeNumericUpDown.Value = pageSize;
            LoadData();
            ToFirstButton.Enabled = ToPreviousButton.Enabled = false;
            ShowButton.Enabled = ToLastButton.Enabled = ToNextButton.Enabled = currentPage < totalPages;
        }

        private void LoadData(int span = 1)
        {
            var data = Core.Context.Products;
            var count = data.Count();
            totalPages = count / pageSize + (count % pageSize > 0 ? 1 : 0);
            PageNumericUpDown.Maximum = totalPages;
            var skip = pageSize * (currentPage - 1 - (span - 1));
            var take = data.OrderBy(p => p.Model).Skip(skip).Take(pageSize * span).ToList();
            ProductsDataGridView.DataSource = take;
            CountLabel.Text = $"Показано {take.Count} из {count} записей";
        }

        private void PageSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            countOfPages = 1;
            pageSize = (int)PageSizeNumericUpDown.Value;
            LoadData();
            ToFirstButton.Enabled = ToPreviousButton.Enabled = currentPage > 1;
            ShowButton.Enabled = ToLastButton.Enabled = ToNextButton.Enabled = currentPage < totalPages;
        }

        private void PageNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            currentPage = (int)PageNumericUpDown.Value;
            LoadData(countOfPages);
            ToFirstButton.Enabled = ToPreviousButton.Enabled = currentPage > 1;
            ShowButton.Enabled = ToLastButton.Enabled = ToNextButton.Enabled = currentPage < totalPages;
        }

        private void ToNextButton_Click(object sender, EventArgs e)
        {
            countOfPages = 1;
            PageNumericUpDown.Value += 1;
            ToFirstButton.Enabled = ToPreviousButton.Enabled = true;
            ShowButton.Enabled = ToLastButton.Enabled = ToNextButton.Enabled = currentPage < totalPages;
        }

        private void ToLastButton_Click(object sender, EventArgs e)
        {
            countOfPages = 1;
            PageNumericUpDown.Value = totalPages;
            ToFirstButton.Enabled = ToPreviousButton.Enabled = currentPage > 1;
            ShowButton.Enabled = ToLastButton.Enabled = ToNextButton.Enabled = false;
        }

        private void ToPreviousButton_Click(object sender, EventArgs e)
        {
            countOfPages = 1;
            PageNumericUpDown.Value -= 1;
            ToFirstButton.Enabled = ToPreviousButton.Enabled = currentPage > 1;
            ShowButton.Enabled = ToLastButton.Enabled = ToNextButton.Enabled = true;
        }

        private void ToFirstButton_Click(object sender, EventArgs e)
        {
            countOfPages = 1;
            PageNumericUpDown.Value = 1;
            ToFirstButton.Enabled = ToPreviousButton.Enabled = false;
            ShowButton.Enabled = ToLastButton.Enabled = ToNextButton.Enabled = currentPage < totalPages;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            countOfPages++;
            PageNumericUpDown.Value++;
            ShowButton.Enabled = currentPage < totalPages;
        }

        private void PageNumericUpDown_Enter(object sender, EventArgs e)
        {
            countOfPages = 1;
        }
    }
}
