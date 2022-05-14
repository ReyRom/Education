using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class EllipsPictureBox : PictureBox
    {
        public EllipsPictureBox()
        {
            InitializeComponent();
            Height = Width = 100;
        }

        public EllipsPictureBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);
        }
    }
}
