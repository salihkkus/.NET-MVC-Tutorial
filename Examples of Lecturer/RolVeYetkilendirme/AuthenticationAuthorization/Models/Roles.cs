using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAuthorization.Models
{
    public class Roles
    {
        public int Id { get; set; }

        public string RoleNames { get; set; }

        public List<Users> Kullanicilar { get; set; }

    }
}