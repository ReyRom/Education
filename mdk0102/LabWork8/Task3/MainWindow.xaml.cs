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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ResultLabel.Content = $"Результат {SumSlider.Value * PercentSlider.Value / 100:f2}";
            ResultTextBlock.Text = $"Сумма: {SumSlider.Value:f2}\nПроцент: {PercentSlider.Value:f2}\nРезультат: {SumSlider.Value * PercentSlider.Value / 100:f2}";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = $"Результат {SumSlider.Value * PercentSlider.Value / 100:f2}";
            ResultTextBlock.Text = $"Сумма: {SumSlider.Value:f2}\nПроцент: {PercentSlider.Value:f2}\nРезультат: {SumSlider.Value * PercentSlider.Value / 100:f2}";
        }
    }
}
