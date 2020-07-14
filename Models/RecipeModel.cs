using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    /// <summary>
    ///  A Recipe is just list of ingredients
    /// </summary>
    class RecipeModel
    {
        public RecipeModel()
        {
            Ingredients = new List<RecipeItemModel>();            
        }
        public List<RecipeItemModel> Ingredients { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }
}
