using AskApollo.Domain.Entities.Common;

namespace AskApollo.Domain.Entities.Users;

public sealed class User : BaseAuditableEntity
{
    public string FullName { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public string PasswordHash { get; private set; } = string.Empty;

    public string Role { get; private set; } = string.Empty;

    public bool IsActive { get; private set; } = true;

    private User()
    {
    }
}
