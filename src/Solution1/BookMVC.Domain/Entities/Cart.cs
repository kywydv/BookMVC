namespace BookMVC.Domain.Entities;

public class Cart : Entity
{
    public int BookId { get; set; } // КнигаID
    public int Quantity { get; set; } // Кількість
    public int Price { get; set; } // Ціна
}