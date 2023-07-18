using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UsersProfile : BaseEnity
    {
        public  string? FirtName { get; set; }
        public string? LastName { get; set; }
        public string? contactNo { get; set; }
        public string? Address { get; set; }
        public Users? users { get; set; }
    }
}
