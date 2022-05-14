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
    public partial class TableForm : Form
    {
        protected string tableName;
        DataTable dataTable;
        public TableForm()
        {
            InitializeComponent();
        }

        protected void Update_Event(object sender, EventArgs e)
        {
            try
            {
                dataTable = DataAccessLayer.GetTable(tableName);
                dataTable.TableName = Text = tableName;
                TableDataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.SetTable(ref dataTable);
                MessageBox.Show("Таблица сохранена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
