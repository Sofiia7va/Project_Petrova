using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Core.Models;

namespace RecipeWPF
{
    public partial class RecipeWindow : Window
    {
        public Recipe NewRecipe { get; private set; }

        public RecipeWindow()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            int cookingTime = 0;
            int.TryParse(textBoxCookingTime.Text, out cookingTime);

            NewRecipe = new Recipe
            {
                Name = textBoxName.Text,
                CookingTime = cookingTime,
                Difficulty = 1,
                CreatedAt = DateTime.Now,
                IsVegetarian = checkBoxVegetarian.IsChecked == true
            };

            DialogResult = true;
            Close();
        }
    }
}
