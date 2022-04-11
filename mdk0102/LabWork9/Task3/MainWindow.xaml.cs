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

        private void SizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontSize = double.Parse((sender as RadioButton).Content as string);
        }

        private void RightRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.TextAlignment = TextAlignment.Right;
        }

        private void CenterRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.TextAlignment = TextAlignment.Center;
        }

        private void LeftRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.TextAlignment = TextAlignment.Left;
        }
    }
}
