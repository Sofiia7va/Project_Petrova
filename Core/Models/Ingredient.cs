using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Ingredient : BaseEntity, IShow
    {
        public Ingredient()
        {
        }
        public string Name { get; set; }       // Назва інгредієнта
        public double Quantity { get; set; }   // Кількість
        public string Unit { get; set; }       // Одиниця вимірювання (грам, мл, шт.)
        public bool IsOptional { get; set; }   // Чи необов’язковий

        public override void Describe()
        {
            Console.WriteLine($"Ingredient: {Name}, Quantity: {Quantity}");
        }

        public void Show()
        {
            Console.WriteLine($"Showing ingredient: {Name}");
        }
    }
}
