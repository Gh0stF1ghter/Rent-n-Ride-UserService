namespace User.BusinessLogic.Models;

public class ClientModel
{
    public Guid Id { get; set; }

    public string UserId { get; set; } = string.Empty;
    public string? Password { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public decimal Balance { get; set; }
    public bool IsRenting { get; set; }
}