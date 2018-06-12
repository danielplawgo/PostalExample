using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PostalExample.Models;
using PostalExample.ViewModels.Users;

namespace PostalExample.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserViewModel>()
                .ReverseMap();
        }
    }
}