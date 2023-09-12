using FluentValidation;
using NewProject.Models;

namespace NewProject.Validation
{
    public class WorkoutValidator : AbstractValidator<RequestWorkoutModel>
    {
        public WorkoutValidator()
        {
            RuleFor(w => w.WorkoutName).NotEmpty().MaximumLength(50).Matches(@"^[A-Za-z\s]*$");
            RuleFor(w => w.Distance).NotEmpty();
            RuleFor(w => w.Speed).NotEmpty();
            RuleFor(w => w.Time).NotEmpty();
            RuleFor(w => w.SportID).NotEmpty();
            RuleFor(w => w.UserID).NotEmpty();
        }
    }
}
