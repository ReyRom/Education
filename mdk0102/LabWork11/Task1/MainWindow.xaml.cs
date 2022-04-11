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
            List<Game> games = new List<Game>
            {
                new Game(){IdGame = 1, Name = "The Witcher 3 Wild Hunt", Site = "cdproject.com", Category = "Action-RPG", Price = 1199},
                new Game(){IdGame = 2, Name = "Space Rangers 2", Site = "1c.ru", Category = "RPG", Price = 399},
                new Game(){IdGame = 3, Name = "League of Legends", Site = "riotgames.com", Category = "MOBA", Price = 0},
                new Game(){IdGame = 4, Name = "Bioshock Infinite", Site = "2k.com", Category = "Action", Price = 799},
                new Game(){IdGame = 5, Name = "Аллоды онлайн", Site = "mail.ru", Category = "MMO-RPG", Price = 399}
            };
            List<string> categories = new List<string>
            {
                "Action-RPG",
                "RPG", 
                "MOBA",
                "Action", 
                "MMO-RPG"
            };
            CategoriesComboBox.ItemsSource = categories;
            GamesDataGrid.ItemsSource = games;
        }

        private void MoreButton_Click(object sender, RoutedEventArgs e)
        {
            var game = (sender as Button).DataContext as Game;
            MessageBox.Show($"Название: {game.Name}\nСайт: {game.Site}\nЖанр: {game.Category}\nЦена: {game.Price:F2}руб");
        }
    }
}
