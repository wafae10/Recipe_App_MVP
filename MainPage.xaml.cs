using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MagicRecipe
{
    public partial class MainPage : ContentPage
    {

        public IList<Ingredient> Ingredients { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            Ingredients = new List<Ingredient>();
            Ingredients.Add(new Ingredient
            {
                Name = "Potatoes",
                Image = "potatoes.jpg"
            });

            Ingredients.Add(new Ingredient
            {
                Name = "Cauliflower",
                Image = "cauliflower.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "carrots",
                Image = "carrots.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "tomatoe",
                Image = "tomatoe.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "onion",
                Image = "onion.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "shrimps",
                Image = "shrimps.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "tuna",
                Image = "tuna.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "meat",
                Image = "meat.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "eggs",
                Image = "eggs.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "lemon",
                Image = "lemon.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "zucchini",
                Image = "zucchini.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "oranges",
                Image = "oranges.jpg"
            });
            
            Ingredients.Add(new Ingredient
            {
                Name = "apple",
                Image = "apple.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "fish",
                Image = "fish.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "mincedmeat",
                Image = "mincedmeat.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "cherrytomatoes",
                Image = "cherrytomatoes.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "drumsticks",
                Image = "drumsticks.jpg"
            });
            Ingredients.Add(new Ingredient
            {
                Name = "cheese",
                Image = "cheese.jpg"
            });

            BindingContext = this;
        }

        //void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Ingredient selectedItem = e.CurrentSelection[0] as Ingredient;

        //}
        // Inside MainPage class

        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                List<Ingredient> selectedIngredients = e.CurrentSelection.Select(item => item as Ingredient).ToList();

                // Call a method to generate recipes based on the selected ingredients
                List<Recipe> generatedRecipes = GenerateRecipes(selectedIngredients);

                // Display the first chosen recipe's photo on the RecipePage
                if (generatedRecipes.Count > 0)
                {
                    Navigation.PushAsync(new RecipePage(generatedRecipes[0].Image));
                }
                else
                {
                    // Handle the case where no recipes are generated
                    DisplayAlert("No Recipes", "No recipes found with the selected ingredients.", "OK");
                }
            }
        }

        List<Recipe> GenerateRecipes(List<Ingredient> selectedIngredients)
        {
            // Your actual recipe generation logic goes here
            // Replace this logic with your own recipe generation algorithm

            List<Recipe> recipes = new List<Recipe>();

            // For simplicity, let's create a recipe for each selected ingredient
            foreach (var ingredient in selectedIngredients)
            {
                recipes.Add(new Recipe
                {
                    Name = $"Recipe with {ingredient.Name}",
                    Image = $"recipe_{ingredient.Name.ToLower()}.jpg" // Replace with the actual image path
                });
            }

            return recipes;
        }

        public void gotosecondpage(object obj, EventArgs arg)
        {
            Navigation.PushAsync(new MainPage());
        }
    
    }
}
