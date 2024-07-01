namespace User.API.ViewModels;

public record ClientViewModel(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber
    );