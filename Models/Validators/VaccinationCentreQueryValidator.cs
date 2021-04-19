using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models.Validators
{
    public class VaccinationCentreQueryValidator : AbstractValidator<VaccinationCentreQuery>
    {
        private int[] allowedPageSizes = new[] {5, 10, 15};

        public VaccinationCentreQueryValidator()
        {
            RuleFor(x => x.PageNumber).GreaterThanOrEqualTo(1);
            RuleFor(x => x.PageSize).Custom((value, context) =>
            {
                if(!allowedPageSizes.Contains(value))
                {
                    context.AddFailure("PageSize", $"PageSize must in [{string.Join(",", allowedPageSizes)}");
                }
            });
                

        }
    }
}
