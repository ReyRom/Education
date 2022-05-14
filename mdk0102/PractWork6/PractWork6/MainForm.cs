using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork6
{
    public partial class MainForm : Form
    {
        BindingList<User> users = new BindingList<User>();
        
        int rowNumber;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Users_ListChanged(object sender, ListChangedEventArgs e)
        {
            foreach (DataGridViewRow row in UsersDataGridView.Rows)
            {
                if (row == null)
                {
                    return;
                }
                if ((row.DataBoundItem as User)?.Password.Length < 6)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(200, 10, 0);
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UsersDataGridView.AutoGenerateColumns = false;
            UsersDataGridView.DataSource = users;
            users.ListChanged += Users_ListChanged;
            users.Add(new User { Login = "admin", Password = "admin" });
            users.Add(new User{ Login = "zxczxc", Password = "zxczxc"});
            users.Add(new User{ Login = "qwerty", Password = "uqwerty"});
            users.Add(new User{ Login = "wasd", Password = "dsaw"});
            users.Add(new User{ Login = "user", Password = "user"});
            users.Add(new User{ Login = "poggers", Password = "pogpogpog"});
            users.Add(new User{ Login = "12345", Password = "12345"});
        }

        private void UsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowNumber = e.RowIndex;
            var user = users.ElementAt(e.RowIndex);
            user.PropertyChanged += User_PropertyChanged;
            new EditForm(user).ShowDialog();
        }

        private void User_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            foreach(DataGridViewRow row in UsersDataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
            UsersDataGridView.Rows[rowNumber].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ffcc66");
        }
    }
}
