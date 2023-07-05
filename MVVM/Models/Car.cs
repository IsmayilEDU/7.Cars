using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class Car : Entity, INotifyPropertyChanged
    {
		private string _make;

		public string Make
		{
			get { return _make; }
			set { 
				_make = value;
				OnPropertyChanged();
			}
		}
		private string _model;

		public string Model
		{
			get { return _model; }
			set {
                _model = value;
				OnPropertyChanged();
			}
		}
		private int _year;

		public int Year
		{
			get { return _year; }
			set {
                _year = value;
				OnPropertyChanged();
			}
		}


		public event PropertyChangedEventHandler? PropertyChanged;
		private void OnPropertyChanged([CallerMemberName] string name = null)
		{
			if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(name)); }
        }
    }
}
