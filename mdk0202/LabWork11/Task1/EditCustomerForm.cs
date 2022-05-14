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
    public partial class EditCustomerForm : Form
    {
        int id;
        DataRow row;
        public EditCustomerForm(int idCustomer)
        {
            InitializeComponent();
            id = idCustomer;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                row["Login"] = LoginTextBox.Text;
                row["Surname"] = SurnameTextBox.Text;
                row["Name"] = NameTextBox.Text;
                row["Email"] = EmailTextBox.Text;
                row["Address"] = AddressTextBox.Text;
                row["Phone"] = PhoneMaskedTextBox.Text;
                customersTableAdapter.Update(marketDataSet.Customers);
                MessageBox.Show($"запись сохранена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                customersTableAdapter.Fill(marketDataSet.Customers);
                row = marketDataSet.Customers.Rows.Find(id);
                LoginTextBox.Text = row["Login"].ToString();
                SurnameTextBox.Text = row["Surname"].ToString();
                NameTextBox.Text = row["Name"].ToString();
                EmailTextBox.Text = row["Email"].ToString();
                AddressTextBox.Text = row["Address"].ToString();
                PhoneMaskedTextBox.Text = row["Phone"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
