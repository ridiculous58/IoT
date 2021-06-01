using FluentValidation;
using Infrastructure.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ValidationServices.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.TelphoneNumber).NotEmpty();
        }


    }
}
