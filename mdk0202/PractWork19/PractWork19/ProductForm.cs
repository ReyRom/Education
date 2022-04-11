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
    public partial class ProductForm : Form
    {
        Product product;
        public ProductForm()
        {
            InitializeComponent();
            product = new Product() {Year = (short)DateTime.Now.Year};
        }

        public ProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ProducerComboBox.DataSource = Core.Context.Producers.ToList();
            ProducerComboBox.DisplayMember = "Name";

            ProducerComboBox.SelectedItem = product.Producer;
            TypeComboBox.SelectedItem = product.Type;
            PriceNumericUpDown.Value = product.Price;
            ModelTextBox.Text = product.Model;
            WeightNumericUpDown.Value = product.Weight ?? 0;
            YearNumericUpDown.Value = product.Year;
            DescriptionTextBox.Text = product.Description;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                if (ProducerComboBox.SelectedItem != null)
                {
                    product.Producer = ProducerComboBox.SelectedItem as Producer;
                }
                else
                {
                    builder.AppendLine("Производитель не может быть пустым");
                }
                if (TypeComboBox.SelectedItem != null)
                {
                    product.Type = TypeComboBox.SelectedItem.ToString();
                }
                else
                {
                    builder.AppendLine("Тип не может быть пустым");
                }
                product.Price = PriceNumericUpDown.Value;
                if (!String.IsNullOrWhiteSpace(ModelTextBox.Text))
                {
                    product.Model = ModelTextBox.Text.Trim();
                }
                else
                {
                    builder.AppendLine("Название модели не может быть пустым");
                }
                if (WeightNumericUpDown.Value == 0)
                {
                    product.Weight = null;
                }
                else
                {
                    product.Weight = WeightNumericUpDown.Value;
                }
                product.Year = (short)YearNumericUpDown.Value;
                product.Description = String.IsNullOrWhiteSpace(DescriptionTextBox.Text) ? null : DescriptionTextBox.Text.Trim();

                if (builder.Length > 0)
                {
                    throw new Exception(builder.ToString());
                }
                if (product.IdProduct == 0)
                {
                    Core.Context.Products.Add(product);
                }
                Core.Context.SaveChanges();
                MessageBox.Show($"Данные успешно сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сохранить запись.Причина: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
