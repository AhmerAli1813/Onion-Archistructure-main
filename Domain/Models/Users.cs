using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Users : BaseEnity
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? password { get; set; }
        public UsersProfile? usersProfile { get; set; }
    }
}
