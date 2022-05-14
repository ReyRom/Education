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

namespace Task4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterForm form = new FilterForm();
            form.OnFilterChange += Filter_Changed;
            form.Show();
        }

        private void Filter_Changed(string value)
        {
            FilesDataGrid.DataSource = new DirectoryInfo(FolderTextBox.Text).GetFiles()
                    .Select(f => new { f.Name, f.CreationTime, f.LastWriteTime, f.Length }).Where(f => f.Name.Contains(value)).ToList();
        }

        private void FolderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(FolderTextBox.Text))
            {
                FilesDataGrid.DataSource = new DirectoryInfo(FolderTextBox.Text).GetFiles()
                    .Select(f => new { f.Name, f.CreationTime, f.LastWriteTime, f.Length }).ToList(); ;
            }
        }
    }
}
