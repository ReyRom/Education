using System;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Task1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                PractWorkSaveFileDialog.Filter = "Текстовые файлы|*.docx|PDF|*.pdf";
                if (PractWorkSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var wordApp = new Word.Application();
                    var document = wordApp.Documents.Add(Environment.CurrentDirectory + @"\templates\template.docx");
                    document.Content.Find.Execute(FindText: "%номер", ReplaceWith: PractWorkNumericUpDown.Value.ToString(), Replace: Word.WdReplace.wdReplaceAll);
                    document.Content.Find.Execute(FindText: "%Название", ReplaceWith: NameTextBox.Text, Replace: Word.WdReplace.wdReplaceAll);
                    document.Content.Find.Execute(FindText: "%текстЗадания", ReplaceWith: TaskTextBox.Text, Replace: Word.WdReplace.wdReplaceAll);

                    var table = document.Tables[1];
                    for (int i = 1; i < VariantsNumericUpDown.Value; i++)
                    {
                        table.Rows.Add(table.Rows[i + 1]);
                    }

                    if (PractWorkSaveFileDialog.FileName.Split('.').Last() == "docx")
                    {
                        document.SaveAs(PractWorkSaveFileDialog.FileName);
                        wordApp.Visible = true;
                    }
                    else
                    {
                        document.SaveAs(PractWorkSaveFileDialog.FileName, Word.WdSaveFormat.wdFormatPDF);
                    }
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewDocumentButton_Click(object sender, EventArgs e)
        {
            try
            {
                PractWorkSaveFileDialog.Filter = "Текстовые файлы|*.docx|PDF|*.pdf";
                if (PractWorkSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var wordApp = new Word.Application();
                    var document = wordApp.Documents.Add();

                    var paragraph = document.Paragraphs.Add();
                    var range = paragraph.Range;
                    Word.InlineShape image = range.InlineShapes.AddPicture(Environment.CurrentDirectory + @"\templates\img.bmp");
                    image.Height = 50;
                    image.Width = 50;
                    range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

                    paragraph = document.Paragraphs.Add();
                    range = paragraph.Range;
                    range.Text = $"Практическая работа №{PractWorkNumericUpDown.Value}";
                    range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    range.Font.Bold = 1;
                    range.Font.Size = 16;
                    range.Font.Name = "Times New Roman";
                    range.InsertParagraphAfter();

                    paragraph = document.Paragraphs.Add();
                    range = paragraph.Range;
                    range.Text = $"{NameTextBox.Text}";
                    range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    range.Font.Bold = 1;
                    range.Font.Size = 16;
                    range.Font.Name = "Times New Roman";
                    range.InsertParagraphAfter();

                    paragraph = document.Paragraphs.Add();
                    range = paragraph.Range;
                    range.Text = $"Задание:";
                    range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    range.ParagraphFormat.LeftIndent = 35f;
                    range.Font.Bold = 1;
                    range.Font.Size = 14;
                    range.Font.Name = "Times New Roman";
                    range.InsertParagraphAfter();

                    paragraph = document.Paragraphs.Add();
                    range = paragraph.Range;
                    range.Text = $"{TaskTextBox.Text}";
                    range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    range.ParagraphFormat.LeftIndent = 35f;
                    range.Font.Bold = 0;
                    range.Font.Size = 14;
                    range.Font.Name = "Times New Roman";
                    range.InsertParagraphAfter();

                    paragraph = document.Paragraphs.Add();
                    range = paragraph.Range;
                    range.Text = $"Таблица 1 — Варианты задания";
                    range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    range.ParagraphFormat.LeftIndent = 0;
                    range.Font.Bold = 0;
                    range.Font.Size = 14;
                    range.Font.Name = "Times New Roman";
                    range.InsertParagraphAfter();

                    paragraph = document.Paragraphs.Add();
                    range = paragraph.Range;
                    var table = document.Tables.Add(range, 1 + (int)VariantsNumericUpDown.Value, 2);
                    range = table.Range;
                    range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                    table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    range = table.Cell(1, 1).Range;
                    range.Text = "№";
                    range.Font.Bold = 1;
                    range.Font.Size = 14;
                    range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    range.Font.Name = "Times New Roman";
                    range = table.Cell(1, 2).Range;
                    range.Text = "Описание варианта";
                    range.Font.Bold = 1;
                    range.Font.Size = 14;
                    range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    range.Font.Name = "Times New Roman";

                    for (int i = 1; i <= VariantsNumericUpDown.Value; i++)
                    {
                        range = table.Rows[1 + i].Cells[1].Range;
                        range.Text = $"{i}";
                        range.Font.Size = 14;
                        range.Font.Name = "Times New Roman";
                    }

                    paragraph = document.Paragraphs.Add();
                    range = paragraph.Range;
                    range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    range.Font.Bold = 0;
                    range.Font.Size = 14;
                    range.Font.Name = "Times New Roman";
                    range.InsertDateTime();
                    range.InsertParagraphAfter();

                    if (PractWorkSaveFileDialog.FileName.Split('.').Last() == "docx")
                    {
                        document.SaveAs(PractWorkSaveFileDialog.FileName);
                        wordApp.Visible = true;
                    }
                    else
                    {
                        document.SaveAs(PractWorkSaveFileDialog.FileName, Word.WdSaveFormat.wdFormatPDF);
                    }
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
