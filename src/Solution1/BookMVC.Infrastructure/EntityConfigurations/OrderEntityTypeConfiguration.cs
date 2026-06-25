using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BookMVC.Domain.Entities;

namespace BookMVC.Infrastructure.EntityConfigurations;

internal class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.DeliveryAddress)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(o => o.TotalAmount)
            .IsRequired();

        builder.HasOne<Cart>()
            .WithOne()
            .HasForeignKey<Order>(o => o.CartId);
    }
}