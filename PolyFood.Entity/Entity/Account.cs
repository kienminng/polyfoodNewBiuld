using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PolyFood.Common.Common;

namespace PolyFood.Entity.Entity;

public class Account : BaseEntity
{
    [Key] 
    public int AccountId { get; set; }

    [Required(ErrorMessage = Constant.User.UsernameNotFound)]
    public string Username { get; set; }

    public string Avatar { get; set; }

    [Required(ErrorMessage = Constant.User.Password)]
    [RegularExpression(Constant.User.PasswordRegex
        , ErrorMessage = Constant.User.PasswordRegexMessage)]
    public string Password { get; set; }

    public int Status { get; set; }
   public int? Decentralization_Id { get; set; }

   [ForeignKey(nameof(Decentralization_Id))]
   public Decentralization? Decentralization { get; set; }

    public string ResestPasswordToken { get; set; } = string.Empty;
    public DateTime? ResetPasswordTokenExpiry { get; set; }

    public User? Users { get; set; }
    public Token? Token { get; set; }
}