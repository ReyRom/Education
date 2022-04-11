using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace PractWork22
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var data = Core.Context.Producers.Select(x => new { x.Name, x.Products.Count });
            ProductsProducersChart.Series[0].Points.Clear();
            foreach (var item in data)
            {
                ProductsProducersChart.Series[0].Points.AddXY(item.Name, item.Count);
            }


            YearNumericUpDown.Maximum = DateTime.Now.Year;
            YearNumericUpDown.Value = DateTime.Now.Year;

            LoadOrders();
            OrdersCostChart.ChartAreas[0].AxisX.Interval = 1;
            OrdersCostChart.Series[0].IsValueShownAsLabel = true;

            OrdersComboBox.DataSource = Core.Context.Orders.ToList();
            OrdersComboBox.DisplayMember = "IdOrder";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFile = new SaveFileDialog();
                saveFile.Filter = "PNG|*.png|TIFF|*.tiff|BMP|*.bmp";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat format;
                    switch (saveFile.FileName.Split('.').LastOrDefault())
                    {
                        case "bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case "tiff":
                            format = ImageFormat.Tiff;
                            break;
                        case "png":
                        default:
                            format = ImageFormat.Png;
                            break;
                    }
                    ProductsProducersChart.SaveImage(saveFile.FileName, format);
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeriesChartType type;
            switch (TypeComboBox.SelectedIndex)
            {
                case 1:
                    type = SeriesChartType.Bar;
                    break;
                case 2:
                    type = SeriesChartType.Point;
                    break;
                default:
                    type = SeriesChartType.Column;
                    break;
            }

            OrdersCostChart.Series[0].ChartType = type;
        }

        private void YearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            var ordersData = Core.Context.Orders.ToList()
                .Where(x => x.DateOfOrder.Year == (int)YearNumericUpDown.Value)
                .Select(x => new { x.IdOrder, Cost = x.OrderContents.Sum(o => o.Quantity * o.Product.Price) });
            OrdersCostChart.Series[0].Points.Clear();
            foreach (var item in ordersData)
            {
                OrdersCostChart.Series[0].Points.AddXY(item.IdOrder.ToString(), item.Cost);
            }
        }

        private void SaveCsvButton_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFile = new SaveFileDialog();
                saveFile.Filter = "CSV|*.csv";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    var productsData = Core.Context.Products.ToList();
                    StringBuilder builder = new StringBuilder();
                    builder.AppendLine("Код;Производитель;Модель;Цена");
                    foreach (var item in productsData)
                    {
                        builder.AppendLine($"{item.IdProduct};{item.Producer.Name};{item.Model};{item.Price}");
                    }
                    File.WriteAllText(saveFile.FileName, builder.ToString(), Encoding.UTF8);

                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SaveBillButton_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFile = new SaveFileDialog();
                saveFile.Filter = "Документ WORD|*.docx";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    var wordApp = new Word.Application();
                    var document = wordApp.Documents.Add(Environment.CurrentDirectory + @"\template.docx");

                    var order = OrdersComboBox.SelectedItem as Order;

                    document.Content.Find.Execute(FindText: "номер_чека", ReplaceWith: order.IdOrder, Replace: Word.WdReplace.wdReplaceOne);
                    document.Content.Find.Execute(FindText: "дд.мм.гггг", ReplaceWith: order.DateOfOrder, Replace: Word.WdReplace.wdReplaceOne);
                    document.Content.Find.Execute(FindText: "$итог", 
                        ReplaceWith: order.OrderContents.Sum(o => o.Quantity * o.Product.Price), Replace: Word.WdReplace.wdReplaceAll);
                    document.Content.Find.Execute(FindText: "n", ReplaceWith: order.OrderContents.Count, Replace: Word.WdReplace.wdReplaceOne);
                    document.Content.Find.Execute(FindText: "дд.мм.гггг чч:мм", ReplaceWith: DateTime.Now, Replace: Word.WdReplace.wdReplaceOne);
                    var orderContent = order.OrderContents.ToList();
                    var table = document.Tables[1];
                    for(int i = 1; i <= orderContent.Count; i++)
                    {
                        var row = table.Rows.Add(table.Rows[i+1]);
                        row.Cells[1].Range.Text = i.ToString();
                        row.Cells[2].Range.Text = orderContent[i - 1].IdProduct.ToString();
                        row.Cells[3].Range.Text = orderContent[i - 1].Product.Model;
                        row.Cells[4].Range.Text = orderContent[i - 1].Product.Price.ToString();
                        row.Cells[5].Range.Text = orderContent[i - 1].Quantity.ToString();
                        row.Cells[6].Range.Text = (orderContent[i - 1].Product.Price * orderContent[i - 1].Quantity).ToString();
                    }
                    table.Rows.Last.Delete();
                    document.SaveAs(saveFile.FileName);
                    wordApp.Quit();
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveExcelButton_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFile = new SaveFileDialog();
                saveFile.Filter = "XLSX|*.xlsx";
                if (saveFile.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                var excelApp = new Excel.Application();
                var productsData = Core.Context.Products.ToList();
                var workbook = excelApp.Workbooks.Add();
                var worksheet = workbook.Worksheets[1];
                worksheet.Cells[1][1] = "Код";
                worksheet.Cells[2][1] = "Производитель";
                worksheet.Cells[3][1] = "Модель";
                worksheet.Cells[4][1] = "Цена";
                for (int i = 1; i <= productsData.Count; i++)
                {
                    worksheet.Cells[1][i + 1] = productsData[i - 1].IdProduct;
                    worksheet.Cells[2][i + 1] = productsData[i - 1].Producer.Name;
                    worksheet.Cells[3][i + 1] = productsData[i - 1].Model;
                    worksheet.Cells[4][i + 1] = productsData[i - 1].Price;
                }
                workbook.SaveAs(saveFile.FileName);
                excelApp.Quit();
                MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
