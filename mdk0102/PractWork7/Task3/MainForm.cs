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
            if (!(ExeCheckBox.Checked && NoExeCheckBox.Checked))
            {
                if (ExeCheckBox.Checked)
                {
                    result = result.Where(f => f.Extension == ".exe").ToList();
                }
                else if (NoExeCheckBox.Checked)
                {
                    result = result.Where(f => f.Extension != ".exe").ToList();
                }
                else
                {
                    result = new List<FileInfo>();
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
    }
}
