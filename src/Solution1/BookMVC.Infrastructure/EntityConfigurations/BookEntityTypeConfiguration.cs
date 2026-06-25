using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BookMVC.Domain.Entities;

namespace BookMVC.Infrastructure.EntityConfigurations;

internal class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Title)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(b => b.Description)
            .HasMaxLength(2000);

        builder.Property(b => b.Price)
            .IsRequired();

        builder.Property(b => b.StockQuantity)
            .IsRequired();

        builder.HasOne<Author>()
            .WithMany()
            .HasForeignKey(b => b.AuthorId);

        builder.HasOne<Genre>()
            .WithMany()
            .HasForeignKey(b => b.GenreId);

        builder.HasOne<Publisher>()
            .WithMany()
            .HasForeignKey(b => b.PublisherId);
    }
}