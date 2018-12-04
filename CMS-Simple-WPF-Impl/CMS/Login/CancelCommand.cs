using System;
using System.Windows;
using System.Windows.Input;

namespace CMS.Login
{
    class CancelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            Application.Current.Shutdown();
            //throw new NotImplementedException();
        }
    }
}
