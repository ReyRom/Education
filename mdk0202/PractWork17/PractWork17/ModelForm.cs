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
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }

        private void RenewEvent_Cause(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = Core.Context.Products;
            var fullCount = data.Count();
            
            var filteredData = RegisterRadioButton.Checked ? data.ToList().Where(p => p.Model.Contains(ModelTextBox.Text)).ToList() :
                                                             data.Where(p => p.Model.Contains(ModelTextBox.Text)).ToList();

            var filteredCount = filteredData.Count;
            CountLabel.Text = $"Показано {filteredCount} из {fullCount} записей";
            ProductsDataGridView.DataSource = filteredData;
        }
    }
}
