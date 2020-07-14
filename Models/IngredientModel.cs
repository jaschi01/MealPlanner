using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    class IngredientModel
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
