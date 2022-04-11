using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Task3
{
    public partial class MainForm : Form
    {
        XmlDocument document;
        int page = 0;
        int pagesCount;
        string filename;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            XmlOpenFileDialog.Filter = "XML|*.xml";
            if (XmlOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                document = new XmlDocument();
                filename = XmlOpenFileDialog.FileName;
                document.Load(filename);
                var root = document.DocumentElement;
                pagesCount = root.ChildNodes.Count - 1;
                CountLabel.Text = root.ChildNodes.Count.ToString();
                LoadXml(page);
                LastButton.Enabled = NextButton.Enabled = AddButton.Enabled = true;
            }
        }

        public void LoadXml(int number)
        {
            var root = document.DocumentElement;
            var author = (XmlElement)root.ChildNodes[number];
            CountryTextBox.Text = author.GetAttribute("Страна");
            NameTextBox.Text = author.GetElementsByTagName("Имя")[0].InnerText;
            SurnameTextBox.Text = author.GetElementsByTagName("Фамилия")[0].InnerText;
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            page = pagesCount;
            LastButton.Enabled = NextButton.Enabled = false;
            PreviousButton.Enabled = FirstButton.Enabled = page != 0;
            LoadXml(page);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            page++;
            LastButton.Enabled = NextButton.Enabled = page != pagesCount;
            PreviousButton.Enabled = FirstButton.Enabled = page != 0;
            LoadXml(page);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            page--;
            LastButton.Enabled = NextButton.Enabled = page != pagesCount;
            PreviousButton.Enabled = FirstButton.Enabled = page != 0;
            LoadXml(page);
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            page = 0;
            LastButton.Enabled = NextButton.Enabled = page != pagesCount;
            PreviousButton.Enabled = FirstButton.Enabled = false;
            LoadXml(page);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var root = document.DocumentElement;
            var author = (XmlElement)root.ChildNodes[page];
            var book = author.AppendChild(document.CreateElement("Книга"));
            book.InnerText = BookTextBox.Text;
            document.Save(filename);
        }
    }
}
