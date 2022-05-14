using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class MainForm : Form
    {
        List<Post> posts;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var data = GetData("https://jsonplaceholder.typicode.com/posts");
            posts = JsonSerializer.Deserialize<List<Post>>(data);
            PostsDataGridView.DataSource = posts;

            CountLabel.Text = posts.Count.ToString();
            UserCountLabel.Text = posts.Select(p => p.IdUser).Distinct().Count().ToString();
            AvgPostsLabel.Text = posts.GroupBy(p => p.IdUser).Average(gr => gr.Select(x => x.IdPost).Count()).ToString();

            var html = GetData("http://arcotel.ru/bibl/pom_stud.php");
            Regex regex = new Regex(@"(?<=href=)(.+\.docx)");
            Match match = regex.Match(html);
            while (match.Success)
            {
                DocxListBox.Items.Add(match.Value.Remove(0,1));
                match = match.NextMatch();
            }
        }

        public static string GetData(string href)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(href);
            }
        }

        public void LoadData()
        {
            int value;
            if (String.IsNullOrWhiteSpace(UserTextBox.Text))
            {
                posts = JsonSerializer.Deserialize<List<Post>>(GetData("https://jsonplaceholder.typicode.com/posts"));
                PostsDataGridView.DataSource = posts;
            }
            else if (Int32.TryParse(UserTextBox.Text, out value))
            {
                posts = JsonSerializer.Deserialize<List<Post>>(GetData($"https://jsonplaceholder.typicode.com/users/{value}/posts"));
                PostsDataGridView.DataSource = posts;
            }
        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (WebSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(AddresTextBox.Text, WebSaveFileDialog.FileName);
                    }
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
