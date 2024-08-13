namespace User.API.ViewModels;

public record ClientViewModel(
    Guid Id,
    string UserId,
    string FirstName,
    string LastName,
    string Email,
    decimal Balance,
    bool IsRenting
    );