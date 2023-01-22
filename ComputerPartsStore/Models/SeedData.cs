using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ComputerPartsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "AMD 5900X",
                    Description = "12-Core Processor",
                    Category = "CPU",
                    Price = 550
                },
                new Product
                {
                    Name = "Intel i7-10700K",
                    Description = "8-Core Processor",
                    Category = "CPU",
                    Price = 369.99m
                },
                new Product
                {
                    Name = "AMD 5950X",
                    Description = "16-Core Processor",
                    Category = "CPU",
                    Price = 750.50m
                },
                new Product
                {
                    Name = "Intel i5-10600K",
                    Description = "6-Core Processor",
                    Category = "CPU",
                    Price = 254.99m
                },
                new Product
                {
                    Name = "Asus ROG STRIX B550",
                    Description = "AMD CPU Compatible Motherboard",
                    Category = "Motherboard",
                    Price = 169.99m
                },
                new Product
                {
                    Name = "MSI MPG Z490 GAMING PLUS",
                    Description = "Intel CPU Compatible Motherboard",
                    Category = "Motherboard",
                    Price = 168.99m
                },
                new Product
                {
                    Name = "Cooler Master Hyper 212 EVO",
                    Description = "CPU Cooler",
                    Category = "Cooler",
                    Price = 34.99m
                },
                new Product
                {
                    Name = "NZXT Kraken X63",
                    Description = "All In One CPU Cooler",
                    Category = "Cooler",
                    Price = 149.99m
                },
                new Product
                {
                    Name = "Corsair Vengeance RGB Pro 16 GB",
                    Description = "(2 x 8 GB) DDR4-3200 CL16 Memory",
                    Category = "Ram",
                    Price = 94.99m
                },
                new Product
                {
                     Name = "G.Skill Trident Z RGB 16 GB",
                     Description = "(2 x 8 GB) DDR4-3600 CL18 Memory",
                     Category = "Ram",
                     Price = 109.99m
                }

                );
                context.SaveChanges();
            }
        }
    }
}