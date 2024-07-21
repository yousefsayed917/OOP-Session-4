using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_2.Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly string Name="yousef"; 
        private readonly string Password="yousef123";
        private readonly string Role="Admin";
        public bool AuthenticateUser(string username, string password)
        {
            if (username==Name&&password==Password)
                return true;
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == Name && Role == role)
                return true;
            return false;
        }
    }
}
