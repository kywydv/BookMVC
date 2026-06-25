namespace BookMVC.Domain.Entities;

public class Order : Entity, IAggregateRoot
{
    public int CartId { get; set; } // КошикID
    public string DeliveryAddress { get; set; } // адреса дост.
    public int DeliveryTime { get; set; } // час дост.
    public PaymentMethod PaymentMethod { get; set; } // спосіб опл.
    public OrderStatus Status { get; set; } // статус
    public int TotalAmount { get; set; } // сума
}