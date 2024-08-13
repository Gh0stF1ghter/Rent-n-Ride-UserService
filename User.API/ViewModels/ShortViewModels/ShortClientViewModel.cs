namespace User.API.ViewModels.ShortViewModels;

public record ShortClientViewModel(
    string Password,
    string FirstName,
    string LastName,
    string Email,
    decimal Balance,
    bool IsRenting
    );