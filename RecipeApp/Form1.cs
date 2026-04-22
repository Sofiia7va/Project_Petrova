using System.IO;
using System.Text.Json;
using Core.Models;
using System.Collections.Generic;

namespace RecipeApp
{
    public partial class Form1 : Form
    {
        private List<Recipe> recipes = new List<Recipe>();
        public Form1()
        {
            InitializeComponent();
            recipes.Add(new Recipe
            {
                Name = "Borshch",
                CookingTime = 60,
                Difficulty = 3,
                CreatedAt = DateTime.Now,
                IsVegetarian = false
            });

            recipes.Add(new Recipe
            {
                Name = "Salad",
                CookingTime = 15,
                Difficulty = 1,
                CreatedAt = DateTime.Now,
                IsVegetarian = true
            });

            dataGridViewRecipes.DataSource = recipes;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RecipeForm form = new RecipeForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                recipes.Add(form.NewRecipe);

                dataGridViewRecipes.DataSource = null;
                dataGridViewRecipes.DataSource = recipes;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecipes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "???????? ???????? ???????",
                    "?????????????",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Recipe selectedRecipe =
                        (Recipe)dataGridViewRecipes.SelectedRows[0].DataBoundItem;

                    recipes.Remove(selectedRecipe);

                    dataGridViewRecipes.DataSource = null;
                    dataGridViewRecipes.DataSource = recipes;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JSON files (*.json)|*.json";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string json = JsonSerializer.Serialize(
                    recipes,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(saveDialog.FileName, json);

                MessageBox.Show("???? ?????????!");
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "JSON files (*.json)|*.json";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openDialog.FileName);

                recipes = JsonSerializer.Deserialize<List<Recipe>>(json);

                dataGridViewRecipes.DataSource = null;
                dataGridViewRecipes.DataSource = recipes;

                MessageBox.Show("???? ???????????!");
            }
        }
    }
}
