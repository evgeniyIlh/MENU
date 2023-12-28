using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace menu
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        private readonly IDataContext _serv = new DataContext();
        public Add()
        {
            InitializeComponent();
        }

      
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dish = new Dish
            {
                Cost = Convert.ToDecimal(cost.Text),
                Name = Convert.ToString(name.Text),
                Type = Convert.ToString(type.Text)
            };
            _serv.AddDish(dish);
        }
    }
}
