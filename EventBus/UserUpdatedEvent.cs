namespace EventBus;

public record UserUpdatedEvent(
    Guid Id,
    string FirstName,
    string LastName,
    bool IsRenting
    );