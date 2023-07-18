using Domain.Models;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserProfileRepository : IUserProfileRepository
    {
        IGenricRepository<UsersProfile> userProfileRepository;

        public UserProfileRepository(IGenricRepository<UsersProfile> _userProfileRepository)
        {
            this.userProfileRepository = _userProfileRepository;
        }

        public UsersProfile GetUsersProfile(long userId)
        {
            return userProfileRepository.GetT(userId);
        }
    }
}
