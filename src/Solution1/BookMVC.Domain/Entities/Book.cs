namespace BookMVC.Domain.Entities;

public class Book : Entity, IAggregateRoot
{
    public string Title { get; set; } // Назва
    public int AuthorId { get; set; } // Автор (ID)
    public int GenreId { get; set; } // ЖанрID
    public int Price { get; set; } // ЦінаID (вказано як int)
    public int PublisherId { get; set; } // ВидавництвоID
    public string Description { get; set; } // Опис
    public int StockQuantity { get; set; } // Кількість на складі
}