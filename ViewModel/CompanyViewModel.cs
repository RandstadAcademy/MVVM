using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModel
{
    public class CompanyViewModel
    {

        private CompanyModel _CompanyModel = new CompanyModel();

        public CompanyViewModel()
        {
            _CompanyModel.CompanyID = 5;
            _CompanyModel.CompanyName = "TomHardware";
            _CompanyModel.Address = "Via della Ram";
            _CompanyModel.City = "Silicon City";

        }



        public int CompanyID
        {
            get
            {
                return _CompanyModel.CompanyID;
            }
            set
            {
                _CompanyModel.CompanyID = value;
            }
        }


        public string CompanyName
        {
            get
            {
                return _CompanyModel.CompanyName;
            }
            set
            {
                _CompanyModel.CompanyName = value;
            }
        }


        public String Address
        {
            get
            {
                return _CompanyModel.Address;
            }
            set
            {
                _CompanyModel.Address = value;
            }
        }


        public String City
        {
            get
            {
                return _CompanyModel.City;
            }
            set
            {
                _CompanyModel.City = value;
            }
        }




    }



    



}
