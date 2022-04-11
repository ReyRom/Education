using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class MainForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        static async Task<string> GetDataAsync(string href)
        {
            try
            {
                return await client.GetStringAsync(href);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        static async Task GetFileAsync(string href, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    var html = await client.GetStringAsync(href);
                    await sw.WriteLineAsync(html);
                    MessageBox.Show($"Файл {fileName} сохранен", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static async Task<string> PostDataAsync(string href, string data)
        {
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage result = await client.PostAsync(href, content);
            return result.StatusCode.ToString();
        }

        private async void LoadButton_ClickAsync(object sender, EventArgs e)
        {
            LoadButton.Enabled = false;
            HttpPictureBox.Visible = true;
            HttpPictureBox.LoadAsync("loader.gif");
            HttpRichTextBox.Text = await GetDataAsync(HrefTextBox.Text);
            LoadButton.Enabled = true;
            HttpPictureBox.Visible = false;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                await GetFileAsync(HrefTextBox.Text, saveFileDialog.FileName);
            }
        }

        private async void PostButton_Click(object sender, EventArgs e)
        {
            PostButton.Enabled = false;
            HttpPictureBox.Visible = true;
            HttpPictureBox.LoadAsync("loader.gif");
            MessageBox.Show(await PostDataAsync(HrefTextBox.Text, HttpRichTextBox.Text));
            PostButton.Enabled = true;
            HttpPictureBox.Visible = false;
        }
    }
}
