using System;
using System.Collections.ObjectModel;
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
using Pattern.Model.InputData;
using Pattern.Model;
using UI.Windows;
using UI.Pages.Shared;

namespace UI.Pages.PatternDependent
{
    /// <summary>
    /// Interaction logic for ClassMenuPage.xaml
    /// </summary>

    public partial class DecoratorPage : Page
    {
        DecoratorInput patternData = (DecoratorInput)Application.Current.Resources["PatternData"];

        private void InitializeElements()
        {
            componentList.ItemsSource = patternData.ConcreteComponents;
            decoratorList.ItemsSource = patternData.ConcreteDecorators;
        }
        
        public DecoratorPage()
        {
            InitializeComponent();
            InitializeElements();
        }

        private void BtnAddComponent_Click(object sender, RoutedEventArgs e)
        {
            patternData.AddConcreteComponent(patternData.Namespace,"NewConcreteComponent");

            MessageBox.Show(patternData.Count(), "OK", MessageBoxButton.OK, MessageBoxImage.Information); // _temp
        }

        private void btnAddDecorator_Click(object sender, RoutedEventArgs e)
        {
            patternData.AddConcreteDecorator(patternData.Namespace, "NewConcreteDecorator");

            MessageBox.Show(patternData.Count(), "OK", MessageBoxButton.OK, MessageBoxImage.Information); // _temp
        }

        private void btnDeleteDecorator_Click(object sender, RoutedEventArgs e)
        {
            if (componentList.SelectedItem != null)
            {
                if (patternData.DeleteConcreteDecorator((ClassData)decoratorList.SelectedItem))
                    MessageBox.Show("Pomyślnie usunięto wybrany element.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);

                else
                    MessageBox.Show("Wybierz z listy element który chcesz usunąć", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show("Wybierz z listy element który chcesz usunąć", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnDeleteComponent_Click(object sender, RoutedEventArgs e)
        {
            if (componentList.SelectedItem != null)
            {
                if (patternData.DeleteConcreteComponent((ClassData)componentList.SelectedItem))
                    MessageBox.Show("Pomyślnie usunięto wybrany element.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
                
                else
                    MessageBox.Show("Wybierz z listy element który chcesz usunąć", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show("Wybierz z listy element który chcesz usunąć", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnConfigDecorator_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new ClassConfigPage(this); // _temp
        }

        private void btnConfigComponent_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new ClassConfigPage(this); // _temp
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)     
        {
            Window.GetWindow(this).Close();
        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
