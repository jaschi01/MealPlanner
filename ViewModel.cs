using LiteDB;
using MealPlanner.Database;
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
        RecipeModel _selectedRecipe;
        public ViewModel()
        {
            DBList = new ObservableCollection<IngredientModel>();
            using (var db = new LiteDatabase(@"D:\MyData.db"))
            {
                var col = db.GetCollection<IngredientModel>("ingredient");
                var ingredient = new IngredientModel();
                ingredient.Name = "Peppers";
                col.Insert(ingredient);
                var ingredient2 = new IngredientModel();
                ingredient2.Name = "Red Peppers";
                col.Insert(ingredient2);

                DBList = new ObservableCollection<IngredientModel>(col.Query().ToList());
            }
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
        public ObservableCollection<IngredientModel> DBList { get; set; }
        public RecipeModel SelectedRecipe
        {
            get { return _selectedRecipe; }
            set
            {
                _selectedRecipe = value;
                OnPropertyChanged("RecipeModel");
                OnPropertyChanged("IngredientList");
            }
        }
        public ObservableCollection<RecipeItemModel> IngredientList
        {
            get
            {
                return new ObservableCollection<RecipeItemModel>(SelectedRecipe.Ingredients);
            }
        }
        
    }
}
