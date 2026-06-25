namespace BookMVC.Domain.Entities;

public class User : Entity, IAggregateRoot
{
    public string Email { get; set; }
    public string Password { get; set; } // Пароль
    public string FullName { get; set; } // ПІБ
    public string Phone { get; set; } // Телефон
}