﻿using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMtest
{
    public class clsContactBasic
    {
        private int _id;
        private string _username;
        private string _firstname;
        private string _lastname;

        public clsContactBasic()
        {
            _id = 0;
            _username = _firstname = _lastname = "";
        }

        public clsContactBasic(int Id, string UserName, string FirstName, string LastName)
        {
            _id = Id;
            _username = UserName;
            _firstname = FirstName;
            _lastname = LastName;
        }

        public void Add(DataRow row)
        {
            _id = (int)row[0];
            _username = row[1].ToString();
            _firstname = row[2].ToString();
            _lastname = row[3].ToString();
        }

        public int Id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }

        public string UserName
        {
            set
            {
                _username = value;
            }
            get
            {
                return _username;
            }
        }

        public string FirstName
        {
            set
            {
                _firstname = value;
            }
            get
            {
                return _firstname;
            }
        }

        public string LastName
        {
            set
            {
                _lastname = value;
            }
            get
            {
                return _lastname;
            }
        }
    }
}
