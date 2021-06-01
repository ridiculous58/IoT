using Entities.DTOs;
using Infrastructure.Entities.Concrete;
using Infrastructure.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DataServices
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
        DataResult<List<UserDto>> GetUsers();

    }
}
