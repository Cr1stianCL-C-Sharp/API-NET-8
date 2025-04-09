using Core.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeding;

public static class DbSeeder
{
    public static void Seed(MySqlContext context)
    {
        // Ensure the database is created and up to date
        context.Database.Migrate();

        if (!context.Products.Any())
        {
            var products = new List<Product>
            {
                new Product { ProductCode = "CRO", Name = "Pencil 2B", Quantity = 10000, Price = 0.27M },
                new Product { ProductCode = "NOT", Name = "notebook college", Quantity = 10000, Price = 0.48M },
                new Product { ProductCode = "NOT", Name = "notebook classic", Quantity = 10000, Price = 0.48M },
                new Product { ProductCode = "BOK", Name = "english learning book", Quantity = 10000, Price = 6.99M },
                new Product { ProductCode = "BOK", Name = "french learning book", Quantity = 10000, Price = 5.99M },
                new Product { ProductCode = "CRO", Name = "eraser standard", Quantity = 10000, Price = 0.23M },
                new Product { ProductCode = "CRO", Name = "pen", Quantity = 10000, Price = 0.28M },
                new Product { ProductCode = "CRO", Name = "scissors", Quantity = 10000, Price = 0.35M },
                new Product { ProductCode = "CRO", Name = "glue", Quantity = 10000, Price = 0.20M },
                new Product { ProductCode = "CRO", Name = "sharpener", Quantity = 10000, Price = 0.22M },
                new Product { ProductCode = "CRO", Name = "chalk", Quantity = 10000, Price = 0.22M },
                new Product { ProductCode = "CRO", Name = "ruber", Quantity = 8000, Price = 0.49M }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
