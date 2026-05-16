using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using WpfApp1.Commands;

namespace WpfApp1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }

        public MainViewModel()
        {
            Recipes = new ObservableCollection<Recipe>();

            Recipes.Add(new Recipe
            {
                Name = "Soup",
                CookingTime = 30,
                Difficulty = 2,
                CreatedAt = DateTime.Now,
                IsVegetarian = true
            });

            Recipes.Add(new Recipe
            {
                Name = "Burger",
                CookingTime = 25,
                Difficulty = 3,
                CreatedAt = DateTime.Now,
                IsVegetarian = false
            });

            AddCommand = new RelayCommand(AddRecipe);
            DeleteCommand = new RelayCommand(DeleteRecipe);
        }

        private void AddRecipe()
        {
            Recipes.Add(new Recipe
            {
                Name = "New Recipe",
                CookingTime = 10,
                Difficulty = 1,
                CreatedAt = DateTime.Now,
                IsVegetarian = false
            });
        }

        private void DeleteRecipe()
        {
            if (Recipes.Count > 0)
            {
                Recipes.RemoveAt(Recipes.Count - 1);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
