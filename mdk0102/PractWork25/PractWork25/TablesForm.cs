using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork25
{
    public partial class TablesForm : StyleForm
    {
        public TablesForm()
        {
            InitializeComponent();
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {
            TablesTabControl.Appearance = TabAppearance.FlatButtons;
            TablesTabControl.ItemSize = new Size(0, 1);
            TablesTabControl.SizeMode = TabSizeMode.Fixed;
            Text = TitleLabel.Text = "Таблицы";
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            TablesTabControl.SelectedTab = ProductsTabPage;
            Text = TitleLabel.Text = ProductsTabPage.Text;
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            TablesTabControl.SelectedTab = OrdersTabPage;
            Text = TitleLabel.Text = OrdersTabPage.Text;
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            TablesTabControl.SelectedTab = CustomersTabPage;
            Text = TitleLabel.Text = CustomersTabPage.Text;
        }

        private void ToMainButton_Click(object sender, EventArgs e)
        {
            TablesTabControl.SelectedTab = MainTabPage;
            Text = TitleLabel.Text = "Таблицы";
        }
    }
}
