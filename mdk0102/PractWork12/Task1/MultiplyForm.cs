using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Task1
{
    public partial class MultiplyForm : Form
    {
        public MultiplyForm()
        {
            InitializeComponent();
        }

        private void MultiplyTableButton_Click(object sender, EventArgs e)
        {
            TableSaveFileDialog.Filter = "Таблицы|*.xlsx";
            if (TableSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var excelApp = new Excel.Application();
                    excelApp.SheetsInNewWorkbook = 1;

                    var workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.Worksheets[1];
                    worksheet.Name = "Умножение";
                    var xOffset = 3;
                    var yOffset = 9;

                    Excel.Range range = worksheet.Range[worksheet.Cells[1 + xOffset][1], worksheet.Cells[9 + xOffset][yOffset]];
                    range.Merge();
                    range.Value = "Таблица умножения";
                    range.Font.Italic = true;
                    range.Font.Bold = true;
                    range.Font.Size = 20;
                    range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            range = worksheet.Cells[i + xOffset][j + yOffset];
                            if (i == 1 || j == 1)
                            {
                                range.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                                range.Font.Color = ColorTranslator.ToOle(Color.Blue);
                                range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                            }
                            if (i == 1 && j == 1)
                            {
                                continue;
                            }
                            range.Value = i * j;
                            range.Font.Size = 15;
                        }
                    }

                    range = worksheet.Range[worksheet.Cells[1 + xOffset][1], worksheet.Cells[9 + xOffset][9 + yOffset]];
                    range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                    range.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                    range.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                    range.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                    workbook.SaveAs(TableSaveFileDialog.FileName);

                    excelApp.Quit();
                    MessageBox.Show("Файл сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
