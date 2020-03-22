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
using UI.Pages.PatternDependent;
using UI.Windows;
using Pattern.Model;

namespace UI.Pages.Shared
{
    /// <summary>
    /// Interaction logic for NamespacePage.xaml
    /// </summary>
    public partial class NamespacePage : Page
    {
        Patterns pattern;
        public NamespacePage(Patterns selectedPattern)
        {
            pattern = selectedPattern;
            InitializeComponent();
        }
        private bool CheckData()
        {
            if (String.IsNullOrEmpty(txtNamespaceName.Text))
                return false;
            else
                return true;
        }
        private void InitResources()
        {
            switch (pattern)
            {
                case Patterns.Dekorator:
                    Pattern.Model.InputData.DecoratorInput p = new Pattern.Model.InputData.DecoratorInput();
                    p.Namespace = txtNamespaceName.Text;
                    Application.Current.Resources["PatternData"] = p;
                    break;

                default:
                    MessageBox.Show("Nie zaimplementowano wybranego wzorca", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }
        private void OpenNewWindow()
        {
            WorkWindow w = new WorkWindow(Window.GetWindow(this));
            w.frame.Content = new DecoratorPage();
            w.Show();
            Window.GetWindow(this).Hide();
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if(CheckData())
            {
                InitResources();
                OpenNewWindow();
            }
            else
                MessageBox.Show("Przed przejściem dalej, należy podać przestrzeń nazw.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new MainPage();
        }
    }
}
