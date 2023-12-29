using System.ComponentModel.DataAnnotations;

namespace PolyFood.Entity.Entity;

public class OrderStatus
{
    [Key] public int Order_Status_Id { get; set; }

    [Required(ErrorMessage = "name can not be null")]
    public string Status_Name { get; set; } = string.Empty;

    public List<Order>? Orders { get; set; }
}