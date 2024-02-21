using System;
using System.Collections.Generic;
using System.Text;

namespace MagicRecipe
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
