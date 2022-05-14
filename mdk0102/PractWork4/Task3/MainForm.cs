using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FolderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(FolderTextBox.Text))
            { 
                FilesDataGridView.DataSource = new DirectoryInfo(FolderTextBox.Text).GetFiles()
                    .Select(f => new { f.Name, f.CreationTime, f.LastWriteTime, f.Length }).ToList(); ;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterForm form = new FilterForm();
            form.dataSender = ChangeFilter;
            form.Show();
        }

        public void ChangeFilter(string filter)
        {
            FilesDataGridView.DataSource = new DirectoryInfo(FolderTextBox.Text).GetFiles()
                    .Select(f => new { f.Name, f.CreationTime, f.LastWriteTime, f.Length }).Where(f => f.Name.Contains(filter)).ToList();
        }
    }
}
