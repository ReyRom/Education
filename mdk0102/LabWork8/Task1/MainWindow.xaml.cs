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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BirthDatePicker.DisplayDateEnd = DateTime.Now;
        }

        private void RegistrButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(LoginTextBox.Text) && 
                !String.IsNullOrWhiteSpace(PasswordPasswordBox.Password) &&
                PasswordPasswordBox.Password == ConfirmPasswordBox.Password)
            {
                MessageBox.Show($"{LoginTextBox.Text}, Вы зарегистрированы", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BirthDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            AgeLabel.Content = (new DateTime(DateTime.Now.Ticks - BirthDatePicker.SelectedDate.Value.Ticks).Year - 1).ToString();
        }
    }
}
