using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Core.Models;

namespace RecipeWPF
{
    public partial class MainWindow : Window
    {
        private List<Recipe> recipes = new List<Recipe>();

        public MainWindow()
        {
            InitializeComponent();

            recipes.Add(new Recipe
            {
                Name = "Soup",
                CookingTime = 30,
                Difficulty = 2,
                CreatedAt = DateTime.Now,
                IsVegetarian = true
            });

            recipes.Add(new Recipe
            {
                Name = "Burger",
                CookingTime = 25,
                Difficulty = 3,
                CreatedAt = DateTime.Now,
                IsVegetarian = false
            });

            dataGridRecipes.ItemsSource = recipes;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            RecipeWindow window = new RecipeWindow();
            window.Owner = this;

            if (window.ShowDialog() == true)
            {
                recipes.Add(window.NewRecipe);
                dataGridRecipes.Items.Refresh();
            }
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Натиснуто кнопку Редагувати");
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Натиснуто кнопку Видалити");
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Натиснуто кнопку Зберегти");
        }

        private void ButtonLoad_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Натиснуто кнопку Завантажити");
        }
    }
}