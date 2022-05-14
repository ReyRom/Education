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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(DataAccessLayer.ConnectionString);
            TablesListBox.DataSource = DataAccessLayer.GetTables();
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataAccessLayer.ExecuteCommand(QueryTextBox.Text).ToString());
        }

        private void QueryScalarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataAccessLayer.ExecuteScalarCommand(QueryTextBox.Text).ToString());
        }

        private void QueryDataSetButton_Click(object sender, EventArgs e)
        {
            QueryDataGridView.DataSource = DataAccessLayer.ExecuteReaderCommand(QueryTextBox.Text);
        }

        private void GetSchemaButton_Click(object sender, EventArgs e)
        {
            QueryDataGridView.DataSource = DataAccessLayer.GetTableSchema(TableTextBox.Text);
        }

        private void GetColumnsButton_Click(object sender, EventArgs e)
        {
            ColumnsListBox.DataSource = DataAccessLayer.GetTableColumns(TableTextBox.Text);
        }
    }
}
