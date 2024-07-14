using Day2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day2.Configuration
{
    internal class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasKey(op => new
            {
                op.OrderId,
                op.ProductId
            });

            builder.HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(op => op.OrderId);

            builder.HasOne(op => op.Product)
                        .WithMany(p => p.OrderProducts)
                        .HasForeignKey(op => op.ProductId);
        }
    }
}
