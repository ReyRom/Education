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
    public partial class EllipsButton : Button
    {
        ButtonShape buttonShape = ButtonShape.Square;
        public ButtonShape ButtonShape
        {
            get => buttonShape; 
            set
            {
                buttonShape = value;
                SetShape();
            }
        }

        private void SetShape()
        {
            GraphicsPath path = new GraphicsPath();
            switch (buttonShape)
            {
                case ButtonShape.Square:
                    path.AddRectangle(new Rectangle(0, 0, Width, Height));
                    Region = new Region(path);
                    break;
                case ButtonShape.Ellips:
                    path.AddEllipse(0, 0, Width, Height);
                    Region = new Region(path);
                    break;
            }
        }

        public EllipsButton()
        {
            InitializeComponent();
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Height = Width = 100;
            BackColor = Color.Aquamarine;
        }

        public EllipsButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Height = Width = 100;
            BackColor = Color.Aquamarine;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetShape();
        }
    }
}
