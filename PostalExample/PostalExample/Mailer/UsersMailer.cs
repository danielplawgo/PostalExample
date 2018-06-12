using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Postal;
using PostalExample.Models;
using PostalExample.ViewModels.Users;

namespace PostalExample.Mailer
{
    public class UsersMailer : BaseMailer, IUserMailer
    {
        public void SendRegisterEmail(User user)
        {
            var email = new RegisterEmail()
            {
                Email = user.Email,
                FirstName = user.FirstName
            };

            //email.Send();
            Send(email);
        }
    }

    public interface IUserMailer
    {
        void SendRegisterEmail(User user);
    }
}