using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Core.Models
{
    public class XmlManager
    {
        private string filePath = "recipes.xml";

        // Експорт тільки вегетаріанських рецептів
        public void ExportVegetarianRecipes(List<Recipe> recipes)
        {
            // LINQ-запит
            var vegetarianRecipes =
                from r in recipes
                where r.IsVegetarian == true
                select r;

            XDocument doc = new XDocument(
                new XElement("Recipes",
                    vegetarianRecipes.Select(r =>
                        new XElement("Recipe",
                            new XElement("Name", r.Name),
                            new XElement("CookingTime", r.CookingTime),
                            new XElement("Difficulty", r.Difficulty),
                            new XElement("CreatedAt", r.CreatedAt),
                            new XElement("IsVegetarian", r.IsVegetarian)
                        )
                    )
                )
            );

            doc.Save(filePath);

            Console.WriteLine("Vegetarian recipes exported to XML.");
        }
        public void CheckXmlFile()
        {
            if (System.IO.File.Exists(filePath))
            {
                Console.WriteLine("XML file exists.");
            }
            else
            {
                Console.WriteLine("XML file not found.");
            }
        }
    }
}