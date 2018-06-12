using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Postal;

namespace PostalExample.ViewModels.Users
{
    public class RegisterEmail : Email
    {
        public string FirstName { get; set; }

        public string Email { get; set; }
    }
}