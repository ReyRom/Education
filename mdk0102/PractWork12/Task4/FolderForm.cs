using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Task4
{
    public partial class FolderForm : Form
    {
        public FolderForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TableSaveFileDialog.Filter = "Таблицы|*.xlsx";
            if (Directory.Exists(FolderTextBox.Text))
            {
                DirectoryInfo directory = new DirectoryInfo(FolderTextBox.Text);

                if (TableSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var excelApp = new Excel.Application();
                        excelApp.SheetsInNewWorkbook = 2;

                        var workbook = excelApp.Workbooks.Add();
                        Excel.Worksheet worksheet = workbook.Worksheets[1];
                        worksheet.Name = "Файлы";

                        worksheet.Cells[1][1] = "номер файла";
                        worksheet.Cells[2][1] = "имя файла";
                        worksheet.Cells[3][1] = "размер файла в КБ";

                        var files = directory.GetFiles().ToList();

                        for (int i = 2; i <= files.Count + 1; i++)
                        {
                            worksheet.Cells[1][i] = i - 1;
                            worksheet.Cells[2][i] = files[i - 2].FullName;
                            worksheet.Cells[3][i] = Math.Round(files[i - 2].Length / 1024.0, 1);
                        }
                        worksheet.Cells[3][files.Count + 2].Formula = $"=SUM(C2:C{files.Count + 1})/1024";

                        worksheet = workbook.Worksheets[2];
                        worksheet.Name = "Подпапки";

                        worksheet.Cells[1][1] = "номер подпапки";
                        worksheet.Cells[2][1] = "имя подпапки";

                        var directories = directory.GetDirectories().ToList();
                        for (int i = 2; i <= directories.Count + 1; i++)
                        {
                            worksheet.Cells[1][i] = i - 1;
                            worksheet.Cells[2][i] = directories[i - 2].Name;
                        }

                        workbook.SaveAs(TableSaveFileDialog.FileName);

                        excelApp.Quit();
                        MessageBox.Show("Файл сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Данная папка не существует", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}