using Microsoft.AspNetCore.Identity;
using System;

namespace FlowerApp.Auth
{
    public class ApplicationUser : IdentityUser
    {
        //birthdate
        public DateTime Birthdate { get; set; }

        //city
        public string City { get; set; }

        //country
        public string Country { get; set; }
    }
}
