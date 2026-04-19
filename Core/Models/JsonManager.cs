using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Core.Models
{
    public class JsonManager
    {
        private string filePath = "recipes.json";

        // Збереження в JSON
        public void SaveRecipes(List<Recipe> recipes)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // гарний формат JSON
            };

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                JsonSerializer.Serialize(fs, recipes, options);
            }
        }

        // Завантаження з JSON
        public List<Recipe> LoadRecipes()
        {
            // Перевірка чи існує файл
            if (!File.Exists(filePath))
            {
                Console.WriteLine("JSON file does not exist.");
                return new List<Recipe>();
            }

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    var recipes = JsonSerializer.Deserialize<List<Recipe>>(fs);

                    if (recipes == null)
                    {
                        return new List<Recipe>();
                    }

                    return recipes;
                }
            }
            catch (JsonException)
            {
                Console.WriteLine("JSON file is corrupted.");
                return new List<Recipe>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new List<Recipe>();
            }
        }
    }
}