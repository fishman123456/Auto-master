using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAutomobile.Infractructure
{
    class DelegateCommand : ICommand
    {
        private Func<object, bool> canExecuteMethod;
        private Action<object> executeMethod;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public DelegateCommand(Action<object> eM, Func<object, bool> cEM = null)
        {
            canExecuteMethod = cEM;
            executeMethod = eM;
        }
        public bool CanExecute(object parameter)
        {
            return this.canExecuteMethod == null || this.canExecuteMethod(parameter);
        }

        public void Execute(object parameter)
        {
            this.executeMethod(parameter);
        }
    }

}
