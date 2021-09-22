using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PollAPI.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
    }
}
