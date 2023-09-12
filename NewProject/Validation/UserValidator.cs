using FluentValidation;
using NewProject.Models;

namespace NewProject.Validation
{
    public class UserValidator : AbstractValidator<RequestUserModel>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty().MaximumLength(50).Matches(@"^[A-Za-z\s]*$");
            RuleFor(u => u.FistName).NotEmpty().MaximumLength(50).Matches(@"^[A-Za-z\s]*$");
            RuleFor(u => u.LastName).NotEmpty().MaximumLength(50).Matches(@"^[A-Za-z\s]*$");
            RuleFor(u => u.Address).NotEmpty().MaximumLength(250).Matches(@"^[A-Za-z\s]*$");
            RuleFor(u => u.PhoneNumber).NotEmpty().MaximumLength(10).Matches(@"^[0-9]*$");
        }
    }
}
