using MealPlanner.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            RecipeList = new ObservableCollection<RecipeModel>();
            RecipeModel recipe = new RecipeModel { Name = "Kababs" };            
            recipe.Ingredients.Add(new RecipeItemModel { Ingredient = new IngredientModel { Name = "Onions" }, NumberOf = 3 });
            recipe.Ingredients.Add(new RecipeItemModel { Ingredient = new IngredientModel { Name = "Peppers" }, NumberOf = 3 });
            RecipeList.Add(recipe);
            RecipeModel recipe2 = new RecipeModel { Name = "Steak" };
            recipe2.Ingredients.Add(new RecipeItemModel { Ingredient = new IngredientModel { Name = "Steak" }, NumberOf = 1 });            
            RecipeList.Add(recipe2);
            SelectedRecipe = RecipeList.First();
        }
        public ObservableCollection<RecipeModel> RecipeList {get;set;}
        public RecipeModel SelectedRecipe { get; set; }
        
    }
}
