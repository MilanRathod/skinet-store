using System;
using System.Text.Json;
using Core.Entities;
using Microsoft.VisualBasic;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    public static async Task SeedAsync(StoreContext context)
    {
        if (!context.Products.Any())
        {
            
            var produtsData = await File.ReadAllTextAsync("../Infrastructure/SeedData/products.json");

            var products = JsonSerializer.Deserialize<List<Product>>(produtsData);
            if(products == null) return;

            context.Products.AddRange(products);
            await context.SaveChangesAsync();

            
        }
    }
}
