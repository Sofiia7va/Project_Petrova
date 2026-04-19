using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Category : BaseEntity, IShow
    {
        public Category()
        {
        }
        public string Name { get; set; }        // Назва категорії (супи, десерти)
        public string Description { get; set; } // Опис категорії
        public int RecipeCount { get; set; }    // Кількість рецептів у категорії
        public bool IsPopular { get; set; }     // Популярність

        public override void Describe()
        {
            Console.WriteLine($"Category: {Name}");
        }

        public void Show()
        {
            Console.WriteLine($"Showing category: {Name}");
        }
    }
}
