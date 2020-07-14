using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    class RecipeItemModel
    {        
        public IngredientModel Ingredient { get; set; }
        public int NumberOf { get; set; }
        public override string ToString()
        {
            return NumberOf.ToString() + " - " + Ingredient.ToString();
        }

    }
    
}
