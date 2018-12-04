using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CMS.Login
{
    class LoginCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        public LoginCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute();
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            _execute();
            // throw new NotImplementedException();
        }

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

    }
}
