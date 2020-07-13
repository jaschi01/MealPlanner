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
            cbList = new ObservableCollection<string>();
            cbList.Add("Jason");
            cbList.Add("jessica");
            cbList.Add("Lucas");
        }
        public ObservableCollection<string> cbList {get;set;}
    }
}
