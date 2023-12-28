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
    /// Логика взаимодействия для Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        private readonly IDataContext _serv = new DataContext();
        public Delete()
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
                    NameLabel.Content = selectedDish.Name;
                    CostLabel.Content = $"Cost: {selectedDish.Cost:C}";
                    TypeLabel.Content = $"Type: {selectedDish.Type}";
                }
                else
                {
                    NameLabel.Content = string.Empty;
                    CostLabel.Content = string.Empty;
                    TypeLabel.Content = string.Empty;
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.TryParse(IdTextBox.Text, out int id))
                {
                    _serv.DeleteDish(id);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
