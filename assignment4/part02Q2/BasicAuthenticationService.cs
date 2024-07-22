using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4.part02Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, int password)
        {
            if (username=="Nouran" && password==123) { return true; }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == "Nouran" && role == "Admin") { return true; }
            return false;
        }
    }
}
