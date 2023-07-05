using Cars.Commands;
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

namespace Cars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string SomeText { get; set; } = "Ismayil12";

        public ICommand command { get; set; }
        public ICommand EditCommand { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            action += Save;
            action += Edit;

            command = new RealCommand(action);
        }

        Action<object> action;
        public void Save(object? prm)
        {
            MessageBox.Show(SomeText);
        }

        public void Edit(object? prm)
        {
            MessageBox.Show("Huseyn");
        }

        public bool CanEdit(object? prm)
        {
            return SomeText.Length >= 8;
        }
    }
}
