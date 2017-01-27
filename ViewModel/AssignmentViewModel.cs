using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModel
{

    
    public class AssignmentViewModel
    {
        private AssignmentModel _AssignmentModel = new AssignmentModel();



        public AssignmentViewModel()
        {
            _AssignmentModel.AssignmentID = 20;
            _AssignmentModel.AssignmentName = "Manager";
            _AssignmentModel.BasicSalary = 50000;
        }


        public int AssignmentID
        {
            get
            {
                return _AssignmentModel.AssignmentID;
            }
            set
            {
                _AssignmentModel.AssignmentID = value;
            }
        }


        public string AssignmentName
        {
            get
            {
                return _AssignmentModel.AssignmentName;
            }
            set
            {
                _AssignmentModel.AssignmentName = value;
            }
        }


        public double BasicSalary
        {
            get
            {
                return _AssignmentModel.BasicSalary;
            }
            set
            {
                _AssignmentModel.BasicSalary = value;
            }
        }


        private TestButtonCommand _ACommand = new TestButtonCommand();
        public TestButtonCommand ACommand
        {
            get
            {
                return _ACommand;
            }

            set
            {
                _ACommand = value;
            }
        }
    }
}
