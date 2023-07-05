using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class ShowCarViewModel
    {
        public Car SelectedCar { get; set; }

        public ShowCarViewModel(Car car) 
        {
            SelectedCar = car;
        }



    }
}
