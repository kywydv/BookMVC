namespace BookMVC.Domain.Entities;

public class Cart : Entity
{
    public int UserId { get; set; }   // ← додай це поле
    public int BookId { get; set; } // КнигаID
    public int Quantity { get; set; } // Кількість
    public int Price { get; set; } // Ціна
}