using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Import
{
    public partial class ImportForm : Form
    {
        string filename;
        public ImportForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;
                PathLabel.Text = Path.GetFileName(filename);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var find = GamesComboBox.SelectedItem as Game;
                var game = Core.Context.Games.FirstOrDefault(x => x.IdGame == find.IdGame);
                game.Logo = File.ReadAllBytes(filename);
                Core.Context.SaveChanges();
                MessageBox.Show("Данные сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            try
            {
                GamesComboBox.DisplayMember = "Name";
                GamesComboBox.DataSource = Core.Context.Games.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImportPizzaButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var data = File.ReadAllLines(dialog.FileName).ToList();
                data.RemoveAt(0);
                foreach (var item in data)
                {
                    var row = item.Split(';');
                    Pizza pizza = new Pizza();
                    pizza.Name = row[1];
                    pizza.Mass = Convert.ToInt16(row[3]);
                    pizza.Price = Convert.ToDecimal(row[4]);
                    var ingredients = row[2].ToLower().Split(',');
                    foreach (var ing in ingredients)
                    {
                        var name = ing.Trim();
                        var ingredient = Core.Context.Ingredients.FirstOrDefault(x => x.Name == name);
                        if (ingredient == null)
                        {
                            ingredient = new Ingredient() { Name = name };
                        }
                        pizza.Ingredients.Add(ingredient);
                    }
                    Core.Context.Pizzas.Add(pizza);
                    Core.Context.SaveChanges();
                }
                MessageBox.Show("Данные сохранены");
            }
        }
    }
}
