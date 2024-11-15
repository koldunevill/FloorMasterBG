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

namespace FloopMasterBG
{
    /// <summary>
    /// Логика взаимодействия для PathersPage.xaml
    /// </summary>
    public partial class PathersPage : Page
    {
        public PathersPage()
        {
            InitializeComponent();
            var patherscontext =  FloopMasterEntities.GetContext().Pathers.ToList();
            PathersListView.ItemsSource = patherscontext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pathers pat = new Pathers();
            pat = (sender as Button).DataContext as Pathers;

            manager.MainFrame.Navigate(new AddEdirPathers(null));
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Pathers pat = new Pathers();
            pat = (sender as Button).DataContext as Pathers;
            manager.MainFrame.Navigate(new AddEdirPathers(pat));
        }
    }
}
