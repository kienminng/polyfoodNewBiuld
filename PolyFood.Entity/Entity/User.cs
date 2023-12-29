using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolyFood.Entity.Entity;

public class User
{
    [Key] 
    public int UserId { get; set; }

    [Required] 
    public string UserName { get; set; }

    public string? Phone { get; set; }

    [Required(ErrorMessage = "Email can not be null")]
    public string Email { get; set; }

    public string? Address { get; set; }
    public int? Account_Id { get; set; }

    [ForeignKey(nameof(Account_Id))] public Account? Account { get; set; }

    [Required] public DateTime Create_At { get; set; } = DateTime.Now;

    public DateTime? Update_At { get; set; }
 //   public List<ProductReview>? ProductReviews { get; set; }
   // public List<Cart>? Carts { get; set; }
   // public List<Order>? Orders { get; set; }
}