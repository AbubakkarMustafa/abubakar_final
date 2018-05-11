using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class user
    {
        private string name;
        private string password;
        private string confirmpassword;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Confirmpassword
        {
            get
            {
                return confirmpassword;
            }

            set
            {
                confirmpassword = value;
            }
        }
    }
}