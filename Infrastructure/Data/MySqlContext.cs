using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public partial class MySqlContext : DbContext
{
    public MySqlContext()
    {
    }

    public MySqlContext(DbContextOptions<MySqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("productID");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasPrecision(7, 2)
                .HasDefaultValueSql("'99999.99'")
                .HasColumnName("price");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("productCode");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
