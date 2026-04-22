using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Models;

namespace RecipeApp
{
    public partial class RecipeForm : Form
    {
        public Recipe NewRecipe { get; private set; }

        public RecipeForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            NewRecipe = new Recipe
            {
                Name = textBoxName.Text,
                CookingTime = (int)numericCookingTime.Value,
                Difficulty = (double)numericDifficulty.Value,
                CreatedAt = dateTimePickerCreated.Value,
                IsVegetarian = checkBoxVegetarian.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            NewRecipe = new Recipe
            {
                Name = textBoxName.Text,
                CookingTime = (int)numericCookingTime.Value,
                Difficulty = (double)numericDifficulty.Value,
                CreatedAt = dateTimePickerCreated.Value,
                IsVegetarian = checkBoxVegetarian.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
