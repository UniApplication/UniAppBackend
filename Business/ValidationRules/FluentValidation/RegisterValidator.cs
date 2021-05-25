using Entity.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RegisterValidator : AbstractValidator<UserForRegisterDto>
    {
        public RegisterValidator()
        {
            RuleFor(s => s.Email).NotEmpty().WithMessage("E-posta adresi gereklidir.");
            RuleFor(U => U.Email).EmailAddress();


            RuleFor(u => u.Password).MinimumLength(6);
        }
    }
}
