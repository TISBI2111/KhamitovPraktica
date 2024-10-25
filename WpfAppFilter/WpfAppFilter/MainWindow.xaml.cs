using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppFilter.Models;

namespace WpfAppFilter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CBatributs.ItemsSource = App.PersAtribut.ToList();


            Refresh();
        }

        private void CBatributs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var filter = App.Pers.ToList();

            var selectedPersAtribut = CBatributs.SelectedItem as PersAtribut;
            
            var searchTEXT = TBSearch.Text;

            if (selectedPersAtribut == null)
                return;
            filter = filter.Where(x => x.PersAtributId == selectedPersAtribut.Id).ToList();

            if(!string.IsNullOrEmpty(searchTEXT))
                filter = filter.Where(x => x.Name.Contains(searchTEXT)).ToList(); 

            DGPers.ItemsSource = filter.ToList();
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void BClean_Click(object sender, RoutedEventArgs e)
        {
            TBSearch.Text = "";
            CBatributs.SelectedItem = null;
            Refresh();
        }
    }
}
