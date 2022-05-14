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

namespace LabWork12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime Date { get => DateTime.Now; }
        bool hidden = false;
        double panelWidth;
        public MainWindow()
        {
            InitializeComponent();

            date.Content = Date;
            panelWidth = sidePanel.Width;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Садовский, Брызгунов");
        }

        private void Statusbar_Checked(object sender, RoutedEventArgs e)
        {
            if (bar != null)
            {
                bar.Visibility = statusbar.IsChecked ? Visibility.Visible : Visibility.Hidden;
            }
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width = panelWidth;
                hidden = false;
            }
            else
            {
                sidePanel.Width = 35;
                hidden = true;
            }
        }
    }
}
