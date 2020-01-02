using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.models
{
    public class user:IdentityUser
    {
        public string Fullname { get; set; }
        public virtual List<file> Files { get; set; }
        public user()
        {
            Files = new List<file>();
        }
    }
}
