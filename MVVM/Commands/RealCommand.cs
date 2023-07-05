using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.Commands
{
    public class RealCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        { 
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;}
        }

        private Predicate<object> _CanExcecute;
        private Action<object> _Excecute;

        public RealCommand(Action<object> Excecute, Predicate<object> CanExcecute) 
        {
            _CanExcecute = CanExcecute;
            _Excecute = Excecute;
        }

        public bool CanExecute(object? parameter)
        {
            return this._CanExcecute(parameter!);
        }

        public void Execute(object? parameter)
        {
            _Excecute(parameter!);
        }
    }
}
