using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services;
using System.Linq;
using System.Collections.Generic;
using onionArchitectre.DTO;

namespace onionArchitectre.Controllers
{
    public class UserController : ControllerBase
    {
        IUserRepository userRepository;
        IUserProfileRepository userProfileRepository;

        public UserController(IUserRepository userRepository, IUserProfileRepository userProfileRepository)
        {
            this.userRepository = userRepository;
            this.userProfileRepository = userProfileRepository;
        }

        [HttpGet]
        public ActionResult ListUser()
        {
            List<Users> IstUser = new List<Users>();
            userRepository.GetUsers().ToList().ForEach(u =>
            {
                Users _users = null;
                UsersProfile usersProfile = userProfileRepository.GetUsersProfile(u.Id);
                _users = new Users()
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                    password = u.password,
                    IPAddress = u.IPAddress,
                    Date = u.Date,
                    usersProfile = new UsersProfile()
                    {
                        FirtName = usersProfile.FirtName,
                        LastName = usersProfile.LastName,
                        contactNo = usersProfile.contactNo,
                        Address = usersProfile.Address,
                        users = _users,
                        Id = u.Id
                    }
                };
                IstUser.Add(_users);
            }) ;
            return Ok (IstUser);

        }
       
        [HttpGet]
        public int CreateUser(UserDTO model)
        {
            Users _usersEntity = new Users
            {
                Username = model.Username,
                Email = model.Email,
                password = model.password,
                Date = model.Date,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                usersProfile = new UsersProfile
                {
                    FirtName = model.FirtName,
                    LastName = model.LastName,
                    contactNo = model.contactNo,
                    Address = model.Address,
                    Date = model.Date,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            userRepository.InserUser(_usersEntity);
            return 1;
        }
    }
}
