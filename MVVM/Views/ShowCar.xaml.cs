using MVVM.Models;
using MVVM.ViewModels;
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
using System.Windows.Shapes;

namespace MVVM.Views
{
    /// <summary>
    /// Interaction logic for ShowCar.xaml
    /// </summary>
    public partial class ShowCar : Window
    {
        public ShowCar(Car selectedCar)
        {
            InitializeComponent();
            DataContext= new ShowCarViewModel(selectedCar);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
