// See https://aka.ms/new-console-template for more information
using System;
using Core.Models;
using System.Linq;
using System.Text;  // Додаємо для Encoding
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; // Встановлюємо UTF-8
        Console.InputEncoding = Encoding.UTF8;  // Для вводу 
        {
            Price p = new Price { Amount = 100, Discount = 10 };

            ChangePrice(p);

            Console.WriteLine($"Price after method: {p.Amount}");
        }
        // Створюємо екземпляри класів
        var recipe = new Recipe
        {
            Name = "Салат Цезар",
            CookingTime = 20,
            Difficulty = 2.5,
            CreatedAt = DateTime.Now,
            IsVegetarian = false
        };

        var ingredient = new Ingredient
        {
            Name = "Куряче філе",
            Quantity = 200,
            Unit = "г",
            IsOptional = false
        };

        var category = new Category
        {
            Name = "Салати",
            Description = "Легкі та корисні страви",
            RecipeCount = 15,
            IsPopular = true
        };

        // Виводимо інформацію в консоль
        Console.WriteLine("=== Recipe ===");
        Console.WriteLine($"Name: {recipe.Name}");
        Console.WriteLine($"Cooking Time: {recipe.CookingTime} min");
        Console.WriteLine($"Difficulty: {recipe.Difficulty}");
        Console.WriteLine($"Created At: {recipe.CreatedAt}");
        Console.WriteLine($"Vegetarian: {recipe.IsVegetarian}");

        Console.WriteLine("\n=== Ingredient ===");
        Console.WriteLine($"Name: {ingredient.Name}");
        Console.WriteLine($"Quantity: {ingredient.Quantity} {ingredient.Unit}");
        Console.WriteLine($"Optional: {ingredient.IsOptional}");

        Console.WriteLine("\n=== Category ===");
        Console.WriteLine($"Name: {category.Name}");
        Console.WriteLine($"Description: {category.Description}");
        Console.WriteLine($"Recipe Count: {category.RecipeCount}");
        Console.WriteLine($"Popular: {category.IsPopular}");

        /*Console.WriteLine("\n=== Boxing / Unboxing ===");

        object obj = 10; // boxing
        int value = (int)obj; // unboxing

        Console.WriteLine($"Object value: {obj}");
        Console.WriteLine($"Unboxed int value: {value}");
        Console.WriteLine("\n=== Performance Test ===");

        Stopwatch sw = new Stopwatch();

        ArrayList arrayList = new ArrayList();

        sw.Start();
        for (int i = 0; i < 1000000; i++)
        {
            arrayList.Add(i);
        }
        sw.Stop();

        Console.WriteLine($"ArrayList time: {sw.ElapsedMilliseconds} ms");

        sw.Reset();

        List<int> list = new List<int>();

        sw.Start();
        for (int i = 0; i < 1000000; i++)
        {
            list.Add(i);
        }
        sw.Stop();

        Console.WriteLine($"List<int> time: {sw.ElapsedMilliseconds} ms");

        Console.WriteLine("\n=== Recipe List ===");

        List<Recipe> recipes = new List<Recipe>
{
    new Recipe { Name="Soup", CookingTime=30, Difficulty=2, CreatedAt=DateTime.Now, IsVegetarian=true },
    new Recipe { Name="Pizza", CookingTime=40, Difficulty=3, CreatedAt=DateTime.Now, IsVegetarian=false },
    new Recipe { Name="Salad", CookingTime=10, Difficulty=1, CreatedAt=DateTime.Now, IsVegetarian=true },
    new Recipe { Name="Burger", CookingTime=25, Difficulty=2, CreatedAt=DateTime.Now, IsVegetarian=false },
    new Recipe { Name="Pasta", CookingTime=20, Difficulty=2, CreatedAt=DateTime.Now, IsVegetarian=false },
    new Recipe { Name="Omelette", CookingTime=5, Difficulty=1, CreatedAt=DateTime.Now, IsVegetarian=true },
    new Recipe { Name="Steak", CookingTime=35, Difficulty=4, CreatedAt=DateTime.Now, IsVegetarian=false },
    new Recipe { Name="Cake", CookingTime=60, Difficulty=5, CreatedAt=DateTime.Now, IsVegetarian=true },
    new Recipe { Name="Sushi", CookingTime=50, Difficulty=4, CreatedAt=DateTime.Now, IsVegetarian=false },
    new Recipe { Name="Pancakes", CookingTime=15, Difficulty=1, CreatedAt=DateTime.Now, IsVegetarian=true }
};
        Console.WriteLine("\n=== Recipes with CookingTime > 20 ===");

        var filtered = recipes.Where(r => r.CookingTime > 20);

        foreach (var r in filtered)
        {
            Console.WriteLine($"{r.Name} | {r.CookingTime}");
        }

        Console.WriteLine("\n=== Sorted Recipes ===");

        var sorted = recipes
            .OrderBy(r => r.CookingTime)
            .ThenBy(r => r.Name);

        foreach (var r in sorted)
        {
            Console.WriteLine($"{r.Name} | {r.CookingTime}");
        }

        Console.WriteLine("\n=== Recipe Names ===");

        var names = recipes.Select(r => r.Name);

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        
        Console.WriteLine("\n=== Search Recipe ===");

        var foundRecipe = recipes.FirstOrDefault(r => r.Name == "Pizza");

        if (foundRecipe != null)
        {
            Console.WriteLine($"Found recipe: {foundRecipe.Name}");
        }
        else
        {
            Console.WriteLine("Recipe not found");
        }

        Console.WriteLine("\n=== Extension Method ===");

        string recipeText = "Simple salad with tomatoes";

        int count = recipeText.WordCount();

        Console.WriteLine($"Word count: {count}");

        Console.WriteLine("\n=== Foreach Iteration ===");

        RecipeStorage storage = new RecipeStorage();

        storage.AddRecipe(new Recipe
        {
            Name = "Soup",
            CookingTime = 30,
            Difficulty = 2,
            CreatedAt = DateTime.Now,
            IsVegetarian = true
        });

        storage.AddRecipe(new Recipe
        {
            Name = "Pizza",
            CookingTime = 40,
            Difficulty = 3,
            CreatedAt = DateTime.Now,
            IsVegetarian = false
        });

        foreach (var item in storage)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("\n=== Dictionary Test ===");

        var r1 = new Recipe
        {
            Name = "Soup",
            CookingTime = 30,
            Difficulty = 2,
            CreatedAt = DateTime.Now,
            IsVegetarian = true
        };

        var r2 = new Recipe
        {
            Name = "Burger",
            CookingTime = 25,
            Difficulty = 3,
            CreatedAt = DateTime.Now,
            IsVegetarian = false
        };

        // Додаємо в Dictionary
        storage.AddRecipeWithId(1, r1);
        storage.AddRecipeWithId(2, r2);

        // Пошук по ID
        var found = storage.FindById(1);

        if (found != null)
        {
            Console.WriteLine($"Found recipe: {found.Name}");
        }

        // LINQ фільтрація словника
        Console.WriteLine("\nVegetarian recipes:");

        var vegRecipes = storage.GetVegetarianRecipes();

        foreach (var item in vegRecipes)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("\n=== HashSet Example ===");

        HashSet<string> tags1 = new HashSet<string>();

        tags1.Add("Salad");
        tags1.Add("Vegetarian");
        tags1.Add("Quick");

        // Спроба додати дублікат
        tags1.Add("Quick");

        Console.WriteLine("Tags in first set:");

        foreach (var tag in tags1)
        {
            Console.WriteLine(tag);
        }

        HashSet<string> tags2 = new HashSet<string>();

        tags2.Add("Quick");
        tags2.Add("Dinner");

        Console.WriteLine("\nCommon tags:");

        tags1.IntersectWith(tags2);

        foreach (var tag in tags1)
        {
            Console.WriteLine(tag);
        }
        
        Recipe r = new Recipe
        {
            Name = "Soup",
            CookingTime = 30
        };

        Ingredient i = new Ingredient
        {
            Name = "Salt",
            Quantity = 5
        };

        Category c = new Category
        {
            Name = "Main dishes"
        };

        Console.WriteLine("=== Describe Methods ===");

        r.Describe();
        i.Describe();
        c.Describe();

        Console.WriteLine("=== Interface Test ===");

        r.Show();
        i.Show();
        c.Show();

        Console.WriteLine("=== Composition Test ===");

        AppController controller = new AppController();
        controller.ShowConfig();

        Console.WriteLine("=== Aggregation Test ===");

        Recipe r1 = new Recipe
        {
            Name = "Borscht",
            CookingTime = 60,
            IsVegetarian = false
        };

        Recipe r2 = new Recipe
        {
            Name = "Salad",
            CookingTime = 15,
            IsVegetarian = true
        };

        RecipeStorage storage = new RecipeStorage();

        // додаємо рецепти
        storage.AddRecipe(r1);
        storage.AddRecipe(r2);

        // перебір через foreach
        foreach (var item in storage)
        {
            item.Describe();
        }

        Console.WriteLine("=== Polymorphism Test ===");

        List<BaseEntity> entities = new List<BaseEntity>();

        entities.Add(r);
        entities.Add(i);
        entities.Add(c);

        foreach (var entity in entities)
        {
            entity.Describe();
        }
        */

        List<Recipe> recipes = new List<Recipe>
{
    new Recipe
    {
        Name = "Soup",
        CookingTime = 30,
        Difficulty = 2,
        CreatedAt = DateTime.Now,
        IsVegetarian = true
    },

    new Recipe
    {
        Name = "Burger",
        CookingTime = 25,
        Difficulty = 3,
        CreatedAt = DateTime.Now,
        IsVegetarian = false
    }
};

        JsonManager json = new JsonManager();

        // Збереження
        json.SaveRecipes(recipes);

        Console.WriteLine("Recipes saved to JSON.");

        // Завантаження
        var loadedRecipes = json.LoadRecipes();

        Console.WriteLine("Loaded recipes:");

        foreach (var r in loadedRecipes)
        {
            Console.WriteLine($"{r.Name} | {r.CookingTime}");
        }

        XmlManager xml = new XmlManager();

        // Експорт тільки вегетаріанських рецептів
        xml.ExportVegetarianRecipes(recipes);
        xml.CheckXmlFile();

        using (ResourceManager rm = new ResourceManager("log.txt"))
        {
            rm.WriteLog("Program started");
            rm.WriteLog("JSON file created");
            rm.WriteLog("XML file created");
        }
    }
    static void ChangePrice(Price price)
    {
        price.Amount = 999;
    }
}
