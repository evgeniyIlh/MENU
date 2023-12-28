using System.Diagnostics.Eventing.Reader;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedValue = selectedItem.Name;

                if (string.IsNullOrEmpty(selectedValue))
                    throw new Exception();

                Page pageToLoad = null;

                switch (selectedValue)
                {
                    case "listOfDishes":
                        pageToLoad = new List();
                        break;
                    case "toDelete":
                        pageToLoad = new Delete();
                        break;
                    case "toUpdate":
                        pageToLoad = new Update();
                        break;
                    case "toAdd":
                        pageToLoad = new Add();
                        break;
                    default:
                        break;
                }
                if (pageToLoad != null)
                {
                    mainFrame.NavigationService.Navigate(pageToLoad);
                }
            }
        }

         


        }
    }
