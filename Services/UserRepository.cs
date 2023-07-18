using Domain.Models;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserRepository : IUserRepository
    {
        IGenricRepository<Users> IuserRepository;
        IGenricRepository<UsersProfile> IuserProfileRepository;

        public UserRepository(IGenricRepository<Users> _iuserRepository, IGenricRepository<UsersProfile> _iuserProfileRepository)
        {
            IuserRepository = _iuserRepository;
            IuserProfileRepository = _iuserProfileRepository;
        }

        public void DeleteUser(long id)
        {
            UsersProfile _UserProfile = IuserProfileRepository.GetT(id);
            IuserProfileRepository.Remove(_UserProfile);

            Users _User = GetUser(id);
            IuserRepository.Remove(_User);
            IuserRepository.SaveChanges();


        }

        public Users GetUser(long id)
        {
            return IuserRepository.GetT(id);
        }

        public IEnumerable<Users> GetUsers()
        {
            return IuserRepository.GetAll();
        }

        public void InserUser(Users users)
        {
             IuserRepository.Insert(users);
        }

        public void UpdateUser(Users users)
        {
             IuserRepository.Update(users);
        }
    }
}
