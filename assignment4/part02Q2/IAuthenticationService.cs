using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4.part02Q2
{
    internal interface IAuthenticationService
    {
        public bool AuthorizeUser (string username, string role);   
        public bool AuthenticateUser(string username, int password);
    }
}
