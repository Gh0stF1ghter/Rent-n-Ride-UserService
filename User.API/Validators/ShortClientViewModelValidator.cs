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
    }
}
