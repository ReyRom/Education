using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class RunningString : UserControl
    {
        public RunningString()
        {
            InitializeComponent();
            SetStartPosition();
        }

        private void SetStartPosition()
        {
            TimeLabel.Location = new Point(Width + 1, 1);
        }

        private void RunningString_Load(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            RunTimer.Start();
            ClockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void RunTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Location = new Point(TimeLabel.Location.X-1, TimeLabel.Location.Y);
            if (-TimeLabel.Location.X > TimeLabel.Width)
            {
                SetStartPosition();
            }
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            TimeLabel.Font = this.Font;
        }
    }
}
