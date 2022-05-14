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
    public partial class DialogForm : StyleForm
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        private void DialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите закрыть форму?", "Внимание",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        protected virtual void ProcessData(){}

        private void OkButton_Click(object sender, EventArgs e)
        {
            ProcessData();
        }
    }
}
