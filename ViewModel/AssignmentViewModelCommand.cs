using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class TestButtonCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;


        public bool CommandStatus = true;

        public bool CanExecute(object parameter)
        {
            return CommandStatus;
        }

        public void Execute(object parameter)
        {
            System.Diagnostics.Debug.Write("AssignmentViewModelCommando:Execute");
        }
    }

    public class AnotherCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
