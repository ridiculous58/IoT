using Entities.DTOs;
using Infrastructure.Entities.Concrete;
using Infrastructure.Utilities.Results;
using Infrastructure.Utilities.Security.JWT;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.AuthServices
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);

        string Deneme();
    }
}
