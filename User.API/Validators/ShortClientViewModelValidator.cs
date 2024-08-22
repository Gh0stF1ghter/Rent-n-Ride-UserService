using FluentValidation;
using User.API.ViewModels.ShortViewModels;

namespace User.API.Validators;

public class ShortClientViewModelValidator : AbstractValidator<ShortClientViewModel>
{
    public ShortClientViewModelValidator()
    {
        RuleFor(c => c.FirstName)
            .MinimumLength(2)
            .MaximumLength(20);

        RuleFor(c => c.LastName)
            .MinimumLength(2)
            .MaximumLength(20);

        RuleFor(c => c.Email)
            .EmailAddress();

        RuleFor(c => c.Password)
            .MinimumLength(8)
            .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]*$")
            .WithMessage("Weak password. Check for one lowercase, one uppercase, one special character and digit");

        RuleFor(c => c.Password)
            .MaximumLength(20)
    }
}
