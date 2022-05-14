using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork21
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Connection.UserChanged += Connection_UserChanged;
        }

        private void Connection_UserChanged(object sender, EventArgs e)
        {
            UserLabel.Text = Connection.CurrentUser.Login;
            ShowButtons();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowButtons();
        }
        void ShowButtons()
        {
            ConnectionButton.Visible = ProductsButton.Visible = OrdersButton.Visible = UsersButton.Visible = false;
            string role = Connection.CurrentUser?.UserRole.Name ?? "";
            switch (role)
            {
                case "Администратор":
                    ConnectionButton.Visible = ProductsButton.Visible = OrdersButton.Visible = UsersButton.Visible = true;
                    break;
                case "Продавец":
                    ProductsButton.Visible = OrdersButton.Visible = true;
                    break;
                case "Покупатель":
                    ProductsButton.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            new ProductsForm().Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            new OrdersForm().Show();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            new UsersForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AuthorizationForm().ShowDialog();
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            new ConnectionForm().Show();
        }
    } 
}
