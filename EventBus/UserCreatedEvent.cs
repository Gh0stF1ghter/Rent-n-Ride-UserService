namespace EventBus;

public record UserCreatedEvent(
    string FirstName,
    string LastName,
    string Email,
    string? PhoneNumber,
    decimal Balance,
    bool IsRenting
    );