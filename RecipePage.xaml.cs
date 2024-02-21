using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// RecipePage.xaml.cs

namespace MagicRecipe
{
    public partial class RecipePage : ContentPage
    {
        public string RecipeImage { get; set; }

        public RecipePage(string recipeImage)
        {
            //InitializeComponent();
            RecipeImage = recipeImage;
            BindingContext = this;
        }
    }
}
