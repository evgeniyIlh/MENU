using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace menu
{
    public class DataContext : IDataContext
    {
        public ObservableCollection<Dish> _data { get; set; }
        public DataContext()
        {
            _data = new ObservableCollection<Dish>();
            LoadDataFromJson();
        }
        public void LoadDataFromJson()
        {
            try
            {
                if (File.Exists("dishes.json"))
                {
                    string jsonContent = File.ReadAllText("dishes.json");
                    _data = JsonConvert.DeserializeObject<ObservableCollection<Dish>>(jsonContent);
                }
                else
                {
                    _data.Add(new Dish { Id = 1, Name = "test1", Cost = 0.0m, Type = "type1" });
                    _data.Add(new Dish { Id = 2, Name = "test2", Cost = 0.0m, Type = "type2" });
                    _data.Add(new Dish { Id = 3, Name = "test3", Cost = 0.0m, Type = "type3" });
                    _data.Add(new Dish { Id = 4, Name = "test4", Cost = 0.0m, Type = "type4" });
                    _data.Add(new Dish { Id = 5, Name = "test5", Cost = 0.0m, Type = "type5" });
                    _data.Add(new Dish { Id = 6, Name = "test6", Cost = 0.0m, Type = "type6" });
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show($"Error reading JSON file: {ex.Message}");
            }

        }
        private void SaveDataToJson()
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(_data, Formatting.Indented);
                File.WriteAllText("dishes.json", jsonContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to JSON file: {ex.Message}");
            }
        }

        public void AddDish(Dish dish)
        {
            if (_data.Any())
            {
                int maxId = _data.Max(d => d.Id);
                dish.Id = maxId + 1;
            }
            else dish.Id = 1;
            _data.Add(dish);
            SaveDataToJson();
        }

        public void DeleteDish(int id)
        {
            var dish = _data.FirstOrDefault(x => x.Id == id);
            _data.Remove(dish);
            SaveDataToJson();
        }

        public ObservableCollection<Dish>? GetAll()
            => _data;

        public Dish? GetDish(int id)
            => _data.FirstOrDefault(x => x.Id==id);
        

        public  void UpdateDish(Dish newDish)
        {
            var oldDish =  _data.FirstOrDefault(x => x.Id == newDish.Id);
            oldDish.Cost = newDish.Cost;
            oldDish.Type = newDish.Type;
            oldDish.Name = newDish.Name;
            SaveDataToJson();
        }
    }
}
