using MealPlanner.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.ViewModels
{
    class RecipeViewModel : ViewModelBase
    {
        #region constrtuctor
        #endregion
        #region Properties
        public ObservableCollection<RecipeItemModel> RecipeIngredients { get; set; }
        #endregion
    }
}
