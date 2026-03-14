using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Category
    {
        public string Name { get; set; }        // Назва категорії (супи, десерти)
        public string Description { get; set; } // Опис категорії
        public int RecipeCount { get; set; }    // Кількість рецептів у категорії
        public bool IsPopular { get; set; }     // Популярність
    }
}
