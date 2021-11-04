using AuthServer.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.API.Validation
{
    public class CreateUserDtoValidator:AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Adresi Boş Olamaz")
                .EmailAddress().WithMessage("Email Geçersiz.");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Zorunlu");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Zorunlu");

        }
    }
}
