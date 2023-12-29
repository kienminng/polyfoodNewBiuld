using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using PolyFood.Entity.Entity;

namespace PolyFood.DTOs.Request.Authen;

public class RegisterRequest
{
    [NotNull] public string? UserName { get; set; }

    public string? Avatar { get; set; } = string.Empty;

    [NotNull] [MinLength(6)] public string? Password { get; set; }

    [EmailAddress] [NotNull] public string? Email { get; set; }

    [MinLength(10)] [MaxLength(13)] public string Phone { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public Account ChangeToAccount()
    {
        var account = new Account()
        {
            Username = UserName,
            Avatar = Avatar,
            Password = Password,
            Users = new User()
            {
                Email = Email,
                UserName = UserName,
                Phone = Phone,
                Address = Address
            },
            Status = 0
        };
        return account;
    }
}