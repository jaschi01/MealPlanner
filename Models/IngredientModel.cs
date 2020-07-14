using LiteDB;
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
        public static List<IngredientModel> GetAll()
        {
            List<IngredientModel> returnList = new List<IngredientModel>();
            using (var db = new LiteDatabase(@"D:\MyData.db"))
            {
                var col = db.GetCollection<IngredientModel>("ingredient");
                returnList = col.Query().ToList();
            }

            return returnList;
        }
    }
}
