using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModel
{
    public class PersonViewModel
    {
        private PersonModel _Person = new PersonModel();

        

        public PersonViewModel()
        {
            _Person.PersonID = 10;
            _Person.City = "Processor City";
            _Person.Name = "Tommaso";
            _Person.Surname = "De Siato";
            _Person.Language = "Italian";
            _Person.AssignmentID = 7;
            _Person.CompanyID = 5;
        }



        public int PersonID
        {
            get
            {
                return _Person.PersonID;
            }
            set
            {
                _Person.PersonID = value;
            }
        }


        public int CompanyID
        {
            get
            {
                return _Person.CompanyID;
            }
            set
            {
                _Person.CompanyID = value;
            }
        }



        public int AssignmentID
        {
            get
            {
                return _Person.AssignmentID;
            }
            set
            {
                _Person.AssignmentID = value;
            }
        }





        public string City
        {
            get
            {
                return _Person.City;
            }
            set
            {
                _Person.City = value;
            }
        }


        public string Language
        {
            get
            {
                return _Person.Language;
            }
            set
            {
                _Person.Language = value;
            }
        }

        public string Name
        {
            get
            {
                return _Person.Name;
            }
            set
            {
                _Person.Name = value;
            }
        }


        public string Surname
        {
            get
            {
                return _Person.Surname;
            }
            set
            {
                _Person.Surname = value;
            }
        }


    }
}
