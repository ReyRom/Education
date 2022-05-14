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
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            ServerNameTextBox.Text = Connection.serverName;
            DbTextBox.Text = Connection.dbName;
            LoginTextBox.Text = Connection.login;
            PasswordTextBox.Text = Connection.password;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Connection.serverName = ServerNameTextBox.Text;
            Connection.dbName = DbTextBox.Text;
            Connection.login = LoginTextBox.Text;
            Connection.password = PasswordTextBox.Text;

            Core.ConnectionString = Connection.ConnectionString;
        }
    }
}
