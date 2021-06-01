using DataAccess.Interfaces;
using Entities.DTOs;
using Infrastructure.Entities.Concrete;
using Infrastructure.Utilities.Results;
using Services.AspectService.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.DataServices
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
      //  [SecuredOperation("admin")]
        public DataResult<List<UserDto>> GetUsers()
        {
            var data = _userDal.GetAll().Select(u =>
            {
                return new UserDto
                {
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.FirstName,
                    PhoneNumber = u.TelphoneNumber
                };
            }).ToList();

            return new SuccessDataResult<List<UserDto>>(data,"Listed Users");
            
        }
    }
}
