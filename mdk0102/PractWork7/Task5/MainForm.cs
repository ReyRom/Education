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

namespace Task5
{
    public partial class MainForm : Form
    {
        List<FileInfo> files = new List<FileInfo>();
        public MainForm()
        {
            InitializeComponent();
            FilesDataGrid.AutoGenerateColumns = false;
        }

        private void FolderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(FolderTextBox.Text))
            {
                DirectoryInfo directories = new DirectoryInfo(FolderTextBox.Text);
                files = directories.GetFiles("*", SearchOption.AllDirectories).ToList();
            }
            RenewList();
        }

        private void RenewEvent_Cause(object sender, EventArgs e)
        {
            RenewList();
        }

        public void RenewList()
        {
            var result = files.Where(f => f.Name.Contains(FilterTextBox.Text, StringComparison.InvariantCultureIgnoreCase)).ToList();

            if (DateComboBox.SelectedIndex != 0)
            {
                if (DateComboBox.SelectedIndex == 1)
                {
                    result = result.Where(f => f.CreationTime.Date >= DateTime.Today).ToList();
                }
                else if (DateComboBox.SelectedIndex == 2)
                {
                    result = result.Where(f => f.CreationTime.Date >= DateTime.Today.AddDays(-7)).ToList();
                }
                else if (DateComboBox.SelectedIndex == 3)
                {
                    result = result.Where(f => f.CreationTime.Month == DateTime.Now.Month && f.CreationTime.Year == DateTime.Now.Year).ToList();
                }
            }

            FilesDataGrid.DataSource = result;
            ItemsLabel.Text = $"Показано {result.Count} из {files.Count} записей";
            if (result.Count == 0)
            {
                MessageBox.Show("Подходящих записей не найдено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FilterTextBox.Text = string.Empty;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateComboBox.SelectedIndex = 0;
        }
    }
}
