using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cars.Commands
{
    public class RealCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public Predicate<object> _CanExcecute;
        public Action<object> _excecute;

        public RealCommand(Action<object> excecute, Predicate<object>? CanExcecute = null)
        {
            this._excecute = excecute;
            this._CanExcecute = CanExcecute!;

        }
        public bool CanExecute(object? parameter)
        {
            if (_CanExcecute == null)
            {
                return true;
            }

            return _CanExcecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _excecute?.Invoke(parameter!);
        }
    }
}
