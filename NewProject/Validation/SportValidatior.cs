using FluentValidation;
using NewProject.Models;

namespace NewProject.Validation
{
    public class SportValidatior: AbstractValidator<RequestSportModel>
    {
        public SportValidatior()
        {
            RuleFor(s => s.SportName).NotEmpty().MaximumLength(50).Matches(@"^[A-Za-z\s]*$");
            RuleFor(s => s.SportDescription).MaximumLength(450).Matches(@"^[A-Za-z\s]*$");
        }
    }
}
