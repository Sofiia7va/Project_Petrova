using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Recipe : BaseEntity, IShow
    {
        public string Name { get; set; }          // Назва рецепта
        public int CookingTime { get; set; }      // Час приготування в хвилинах
        public double Difficulty { get; set; }    // Складність від 1 до 5
        public DateTime CreatedAt { get; set; }   // Дата створення рецепту
        public bool IsVegetarian { get; set; }    // Вегетаріанський чи ні

        public override void Describe()
        {
            Console.WriteLine($"Recipe: {Name}, Time: {CookingTime}");
        }

        public void Show()
        {
            Console.WriteLine($"Showing recipe: {Name}");
        }
    }
}
