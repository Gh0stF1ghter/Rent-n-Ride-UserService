namespace User.BusinessLogic.Models;

public class ClientModel
{
    public Guid Id { get; set; }

    public string UserId { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public bool IsRenting { get; set; }
}