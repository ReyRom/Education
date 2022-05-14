using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork25
{
    public partial class StyleForm : Form
    {
        public StyleForm()
        {
            InitializeComponent();
        }
        void SetStyle(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is Button)
                {
                    var button = (Button)item;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Height = 30;
                    button.ForeColor = ColorTranslator.FromHtml("#132b4f");
                    if (button.Text.Contains("Отмена"))
                    {
                        button.BackColor = Color.Red;
                    }
                    else
                    {
                        button.BackColor = ColorTranslator.FromHtml("#f79420");
                    }
                }
                if (item.HasChildren)
                {
                    SetStyle(item);
                }
            }

        }

        private void StyleForm_Load(object sender, EventArgs e)
        {
            SetStyle(this);
            DateLabel.Text = DateTime.Now.ToShortDateString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
