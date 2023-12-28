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
    /// Логика взаимодействия для Update.xaml
    /// </summary>
    public partial class Update : Page
    {
        private readonly IDataContext _serv = new DataContext();
        public Update()
        {
            InitializeComponent();
        }
        private void IdTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(IdTextBox.Text, out int enteredId))
            {
                Dish selectedDish = _serv.GetDish(enteredId);
                if (selectedDish != null)
                {
                    NameLabel.Text = selectedDish.Name;
                    CostLabel.Text = $"{selectedDish.Cost}";
                    TypeLabel.Text = $"{selectedDish.Type}";
                }
                else
                {
                    NameLabel.Text = string.Empty;
                    CostLabel.Text = string.Empty;
                    TypeLabel.Text = string.Empty;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var updated = new Dish
            {
                Id = Convert.ToInt32(IdTextBox.Text),
                Name = Convert.ToString(NameLabel.Text),
                Cost = Convert.ToDecimal(CostLabel.Text),
                Type = Convert.ToString(TypeLabel.Text)
           };
            _serv.UpdateDish(updated);
        }
    }
}
