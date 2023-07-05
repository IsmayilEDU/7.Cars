using MVVM.Commands;
using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using MVVM.Views;
using System.Windows;

namespace MVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Accessors

        //  Cars
        public ObservableCollection<Car> Cars { get; set; }


        //  Selected Car
        private Car _SelectedCar;
        public Car SelectedCar
        {
            get { return _SelectedCar; }
            set 
            {
                _SelectedCar = value;
                OnPropertyChanged();
            }
        }

        //  Commands
        public RealCommand ShowCommand { get; set; }
        public RealCommand DeleteCommand { get; set; }


        #endregion


        public MainViewModel() 
        {
            Cars = new()
            {
                new Car(){Id = 1, Make = "Kia", Model ="Cerato", Year = 2012 },
                new Car(){Id = 2, Make = "Hyundai", Model ="IX35", Year = 2020 },
                new Car(){Id = 3, Make = "Aston Martin", Model ="Excelent", Year = 2022 },
                new Car(){Id = 4, Make = "Porshe", Model ="Panamera", Year = 2003 },
                new Car(){Id = 5, Make = "Nissan", Model ="Paturl", Year = 2008 }
            };

            SelectedCar = Cars[0];

            ShowCommand = new(ShowCaR, CheckProperties);
            DeleteCommand = new(DeleteCar, CheckProperties);

        }

        #region Functions of commands

        private bool CheckProperties(object prm)
        {
            return ((SelectedCar.Make != null) && (SelectedCar.Model != null) && (SelectedCar.Year > 0));
        }

        private void ShowCaR(object prm)
        {
            ShowCar showCar = new(SelectedCar);
            showCar.ShowDialog();
        }

        private void DeleteCar(object prm)
        {
            Cars.Remove(SelectedCar);
            SelectedCar = Cars[0];
        }

        #endregion





        #region PropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(name)); }
        }
        #endregion


    }
}
