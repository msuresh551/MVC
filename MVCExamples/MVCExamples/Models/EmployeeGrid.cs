using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExample1.Models
{
    public class EmployeeGrid
    {

        private int iD;
        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }
        private string _Username;

        private string _EmailID;

        public string EmailID
        {
            get
            {
                return _EmailID;
            }

            set
            {
                _EmailID = value;
            }
        }

        public string Username
        {
            get
            {
                return _Username;
            }

            set
            {
                _Username = value;
            }
        }
        private string _Mname;

        public string Mname
        {
            get
            {
                return _Mname;
            }

            set
            {
                _Mname = value;
            }
        }
        private string _Lname;

        public string Lname
        {
            get
            {
                return _Lname;
            }

            set
            {
                _Lname = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
        private string _City;

        public string City
        {
            get
            {
                return _City;
            }

            set
            {
                _City = value;
            }
        }
        private string _Fname;

        public string Fname
        {
            get
            {
                return _Fname;
            }

            set
            {
                _Fname = value;
            }
        }

        private string phone;
    }
}