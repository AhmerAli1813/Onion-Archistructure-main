using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
namespace Services
{
    public interface IUserRepository
    {
        IEnumerable<Users> GetUsers();
        Users GetUser(long id);
        void InserUser(Users users);
        void UpdateUser(Users users);
        void DeleteUser(long id);
    }
}
