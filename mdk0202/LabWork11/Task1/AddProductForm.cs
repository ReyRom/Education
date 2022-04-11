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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            YearNumericUpDown.Maximum = DateTime.Now.Year;
            YearNumericUpDown.Value = DateTime.Now.Year;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Fill(this.marketDataSet.Products);
                this.producersTableAdapter.Fill(this.marketDataSet.Producers);
                ProducerComboBox.DataSource = marketDataSet.Producers;
                ProducerComboBox.ValueMember = "IdProducer";
                ProducerComboBox.DisplayMember = "Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = marketDataSet.Products.NewProductsRow();
                row["IdProducer"] = ProducerComboBox.SelectedValue;
                row["Type"] = TypeComboBox.SelectedItem;
                row["Model"] = ModelTextBox.Text;
                row["Price"] = PriceNumericUpDown.Value;
                row["Year"] = YearNumericUpDown.Value;
                row["Weight"] = MassNumericUpDown.Value;
                row["Description"] = DescriptionTextBox.Text;
                row["Count"] = 100;
                row["IsDeleted"] = false;
                marketDataSet.Products.Rows.Add(row);
                productsTableAdapter.Update(marketDataSet.Products);
                MessageBox.Show($"запись сохранена под номером {row["IdProduct"]}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
