using Domain.Models;

namespace onionArchitectre.DTO
{
    public class UserDTO
    {

        public Int64 Id { get; set; }
        public string? FirtName { get; set; }
        public string? LastName { get; set; }
        public string? contactNo { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? IPAddress { get; set; }
        public string? password { get; set; }
        public DateTime Date { get; set; }
        
    }
}
