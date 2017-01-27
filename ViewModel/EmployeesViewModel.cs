using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class EmployeesViewModel : ViewModelBase
    {
        public List<EmployeeModel> Employees { get; set; }

        private EmployeeModel _Employee = null;

        public EmployeeModel Employee
        {
            get
            {
                if (_Employee == null)
                {
                    _Employee = new EmployeeModel();
                }


                return _Employee;
            }

            set
            {
                _Employee = value;
            }

    }
}
