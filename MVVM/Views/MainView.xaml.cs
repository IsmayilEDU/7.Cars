using MVVM.Commands;
using MVVM.Models;
using MVVM.ViewModels;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MVVM.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        MainViewModel mainViewModel = new MainViewModel();

        public MainView()
        {
            InitializeComponent();
            this.DataContext = mainViewModel;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mainViewModel.SelectedCar = ListOfCars.SelectedItem as Car;
        }

        private void ListOfCars_Loaded(object sender, RoutedEventArgs e)
        {
            ListOfCars.SelectedIndex = 0;
        }
    }
}
