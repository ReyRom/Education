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
using System.Xml;

namespace Task1
{
    public partial class MainForm : Form
    {
        XmlDocument document;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            document = new XmlDocument();
            XmlDeclaration declaration = document.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            XmlComment comment = document.CreateComment("Информация об авторах из разных стран");
            XmlElement root = document.CreateElement("Авторы");
            document.AppendChild(declaration);
            document.AppendChild(comment);
            document.AppendChild(root);
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            XmlSaveFileDialog.Filter = "XML|*.xml";
            if (XmlSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                document.Save(XmlSaveFileDialog.FileName);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var root = document.DocumentElement;
            var author = root.AppendChild(document.CreateElement("Автор"));
            var country = author.Attributes.Append(document.CreateAttribute("Страна"));
            country.Value = CountryTextBox.Text;
            var name = author.AppendChild(document.CreateElement("Имя"));
            name.InnerText = NameTextBox.Text;
            var surname = author.AppendChild(document.CreateElement("Фамилия"));
            surname.InnerText = SurnameTextBox.Text;

            CountryTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            SurnameTextBox.Text = string.Empty;
        }
    }
}
