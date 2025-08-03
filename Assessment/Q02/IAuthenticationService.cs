using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Q02
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser();
        public void AuthorizeUser();

    }
}
