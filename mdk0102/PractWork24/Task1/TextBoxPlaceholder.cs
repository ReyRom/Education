using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class TextBoxPlaceholder : TextBox
    {
        private string placeholder;
        public string Placeholder
        {
            get
            {
                return placeholder;
            }
            set
            {
                placeholder = value;
                SetTextFromPlaceholder();
            }
        }

        private void SetTextFromPlaceholder()
        {
            this.Text = placeholder;
        }

        public TextBoxPlaceholder()
        {
            InitializeComponent();

            ForeColor = Color.DarkGray;
        }

        public TextBoxPlaceholder(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (Text == placeholder)
            {
                Text = null;
            }
            ForeColor = Color.Black;
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (String.IsNullOrEmpty(Text))
            {
                Text = placeholder;
                ForeColor = Color.DarkGray;
            }
        }
    }
}
