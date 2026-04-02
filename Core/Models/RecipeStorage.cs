using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Core.Models
{
    public class RecipeStorage : IEnumerable<Recipe>
    {
        // Список рецептів
        private List<Recipe> recipes = new List<Recipe>();

        // Dictionary для швидкого пошуку
        private Dictionary<int, Recipe> recipeDictionary
            = new Dictionary<int, Recipe>();

        // Додавання рецепту в список
        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        // Додавання рецепту з ID у Dictionary
        public void AddRecipeWithId(int id, Recipe recipe)
        {
            recipeDictionary[id] = recipe;
        }

        // Пошук рецепту за ID
        public Recipe FindById(int id)
        {
            if (recipeDictionary.ContainsKey(id))
                return recipeDictionary[id];

            return null;
        }

        // LINQ-запит для словника
        public List<Recipe> GetVegetarianRecipes()
        {
            return recipeDictionary
                .Where(r => r.Value.IsVegetarian)
                .Select(r => r.Value)
                .ToList();
        }

        // IEnumerable — для foreach
        public IEnumerator<Recipe> GetEnumerator()
        {
            foreach (var recipe in recipes)
            {
                yield return recipe;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}