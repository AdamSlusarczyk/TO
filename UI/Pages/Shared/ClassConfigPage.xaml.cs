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
using UI.Windows;

namespace UI.Pages.Shared
{
    /// <summary>
    /// Interaction logic for ClassConfigPage.xaml
    /// </summary>
    public partial class ClassConfigPage : Page
    {
        Page back;

        public ClassConfigPage()
        {
            InitializeComponent();
        }

        public ClassConfigPage(Page back)
        {
            InitializeComponent();
            this.back = back;
        }

        private void BtnCancer_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = back; 
        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
