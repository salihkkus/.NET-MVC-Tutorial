using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAuthorization.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string PasswordHash { get; set; }
        public int RolId { get; set; }
        public Roles Rol { get; set; }
    }
}