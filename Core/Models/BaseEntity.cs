using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    // Абстрактний базовий клас
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // virtual метод 
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }

        // abstract метод (обов’язково override)
        public abstract void Describe();
    }
}
