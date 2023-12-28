using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    public interface IDataContext
    {
        ObservableCollection<Dish>? GetAll();
        Dish? GetDish(int id);
       void AddDish(Dish dish);
       void UpdateDish(Dish dish);
       void DeleteDish(int id);
    }
}
