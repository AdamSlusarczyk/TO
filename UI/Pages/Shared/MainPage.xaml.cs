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
using UI.Model;

namespace UI.Pages.Shared
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Patterns selectedPattern;

        private bool GetData()
        {
            if (comboBox.SelectedItem == null)
                return false;

            else
                return true; 
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (GetData())
            {
                selectedPattern = (Patterns)comboBox.SelectedItem;
                Window.GetWindow(this).Content = new NamespacePage(selectedPattern); ;      
            }
            else
                MessageBox.Show("Przed przejściem dalej, należy wybrać z listy wzorzec projektowy.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
