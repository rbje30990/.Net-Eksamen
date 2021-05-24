using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Eksamensprojekt_Rema1000.Models;

namespace Rema1000.Data
{
    public static class ModelBuilderExtensions
    {
        public static void CategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Cakes",
                    Description = "You will eat it all day"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Toothpaste",
                    Description = "Used after eating cake"
                }
                );
        }
        public static void SupplierSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    SupplierId = 1,
                    Name = "Mike Johnson",
                    Address = "Abildvej",
                    ZipCode = 7100,
                    ContactPerson = "Mike Johnson",
                    Email = "mikeJohn@gmail.com",
                    PhoneNumber = "+45 32 53 23 95"
                },
                new Supplier
                {
                    SupplierId = 2,
                    Name = "Susanne Jensen",
                    Address = "Frejasgade",
                    ZipCode = 8700,
                    ContactPerson = "Susanne Jensen",
                    Email = "susjensen@gmail.com",
                    PhoneNumber = "+45 74 66 84 61"
                }
                );
        }
        public static void ProductSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Cheesecake",
                    Description = "Yes please",
                    Kilograms = 1.5,
                    QuantityInPackage = 1,
                    Price = 250,
                    Stock = 30,
                    CategoryId = 1,
                    SupplierId = 1,
                },
                new Product
                {
                    ProductId = 2,
                    Name = "KajKage",
                    Description = "But what about Andrea?",
                    Kilograms = 2.4,
                    QuantityInPackage = 5,
                    Price = 50,
                    Stock = 1001,
                    CategoryId = 1,
                    SupplierId = 2,
                }, new Product
                {
                    ProductId = 3,
                    Name = "Colgate",
                    Description = "Wonderful taste",
                    Kilograms = 0.1,
                    QuantityInPackage = 3,
                    Price = 20.99,
                    Stock = 1400,
                    CategoryId = 2,
                    SupplierId = 1,
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Jason",
                    Description = "Healthy mouth control paste",
                    Kilograms = 0.2,
                    QuantityInPackage = 1,
                    Price = 35,
                    Stock = 100,
                    CategoryId = 2,
                    SupplierId = 2,
                }
                );
        }

    }
}
