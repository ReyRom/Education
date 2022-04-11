using PractWork20.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork20
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TypeComboBox.DataSource = Core.Context.Products.Select(x => x.Type).Distinct().ToList();
        }
        void LoadData()
        {
            SqlParameter type = new SqlParameter("@type", TypeComboBox.SelectedItem.ToString());
            SqlParameter price = new SqlParameter("@price", MaxPriceNumericUpDown.Value);
            var data = Core.Context.Database.SqlQuery<Product>("SELECT * FROM Products WHERE Type = @type AND Price <= @price", type, price);
            ProductsDataGridView.DataSource = data.ToList();
        }

        private void RenewEvent_Cause(object sender, EventArgs e)
        {
            LoadData();
        }

        private void IncreaesPriceButton_Click(object sender, EventArgs e)
        {
            SqlParameter type = new SqlParameter("@type", TypeComboBox.SelectedItem.ToString());
            SqlParameter percent = new SqlParameter("@percent", PercentNumericUpDown.Value);
            var lines = Core.Context.Database.ExecuteSqlCommand("UPDATE Products SET Price = Price * (@percent + 100)/100 WHERE Type = @type", type, percent);
            MessageBox.Show($"Изменено строк: {lines}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void GetProductButton_Click(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(IdProductTextBox.Text, out id))
            {
                SqlParameter idParam = new SqlParameter("@id", id);
                var info = Core.Context.Database.SqlQuery<string>("SELECT [dbo].[GetProductInfo](@id)", idParam).FirstOrDefault();
                MessageBox.Show($"{info}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Некорректный ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetOrderContentButton_Click(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(IdOrderTextBox.Text, out id))
            {
                var data = Core.Context.GetOrder(id).ToList();
                OrderContentDataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show($"Некорректный ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IncreasePriceProcButton_Click(object sender, EventArgs e)
        {
            ObjectParameter lines = new ObjectParameter("rowCount", typeof(int));
            Core.Context.IncreasePrice(MarkUpNumericUpDown.Value, TypeComboBox.SelectedItem.ToString(), lines);
            MessageBox.Show($"Изменено строк: {lines.Value}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }
}
