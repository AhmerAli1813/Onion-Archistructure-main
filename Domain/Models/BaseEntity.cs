using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BaseEnity
    {
        public Int64 Id { get; set; }
        public DateTime Date { get; set; }
        public string? IPAddress { get; set; }
    }
}
