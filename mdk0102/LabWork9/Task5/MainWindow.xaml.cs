using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            sliderRed.IsEnabled = checkBoxRed.IsChecked.Value;

            sliderGreen.IsEnabled = checkBoxGreen.IsChecked.Value;

            sliderBlue.IsEnabled = checkBoxBlue.IsChecked.Value;
            ChangeColor();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        void ChangeColor()
        {
            var red = checkBoxRed.IsChecked.Value ? (byte)sliderRed.Value : (byte)0;
            var green = checkBoxGreen.IsChecked.Value ? (byte)sliderGreen.Value : (byte)0;
            var blue = checkBoxBlue.IsChecked.Value ? (byte)sliderBlue.Value : (byte)0;
            Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(red, green, blue));
            rgbColorLabel.Content = $"{red}, {green}, {blue}";
            hexColorLabel.Content = $"#{(red < 16 ? "0" : "") + Convert.ToString(red, 16)}{(green < 16 ? "0" : "") + Convert.ToString(green, 16)}{(blue < 16 ? "0" : "") + Convert.ToString(blue, 16)}";
            oleColorLabel.Content = ColorTranslator.ToOle(System.Drawing.Color.FromArgb(red, green, blue));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            checkBoxRed.IsChecked = true;
            checkBoxGreen.IsChecked = true;
            checkBoxBlue.IsChecked = true;
            sliderRed.Value = 255;
            sliderGreen.Value = 255;
            sliderBlue.Value = 255;
        }
    }
}
