using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator(VaccinationCentresContext dbContext)
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.PasswordHash).MinimumLength(8);

            RuleFor(x => x.Email).Custom((value, context) =>
                {
                    var emailInUse = dbContext.Users.Any(u => u.Email == value);
                    if(emailInUse)
                    {
                        context.AddFailure("Email", "That email is taken");
                    }
                });

        }
    }
}
