using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task5
{
    /// <summary>
    /// Логика взаимодействия для ColorDialog.xaml
    /// </summary>
    public partial class ColorDialog : Window
    {
        Color color = Color.FromRgb(0, 0, 0);
        public Color Color { get=>color; }
        public ColorDialog()
        {
            InitializeComponent();
        }
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        void ChangeColor()
        {
            var red = (byte)sliderRed.Value;
            var green = (byte)sliderGreen.Value;
            var blue =(byte)sliderBlue.Value;
            color = Color.FromRgb(red, green, blue);
            colorTake.Background = new SolidColorBrush(color);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
