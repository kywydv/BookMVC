namespace BookMVC.Domain.Entities;

public enum PaymentMethod
{
    Cash,
    CardOnDelivery,
    OnlinePayment
}

public enum OrderStatus
{
    New,
    Processing,
    Shipped,
    Completed,
    Canceled
}