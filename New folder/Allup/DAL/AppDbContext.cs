using Allup.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Laptop", Image = "category-1.jpg", IsMain = true, IsDeleted = false},
                new Category { Id = 2, Name = "Computer", Image = "category-2.jpg", IsMain = true, IsDeleted = false },
                new Category { Id = 3, Name = "Smartphone", Image = "category-3.jpg", IsMain = true, IsDeleted = false},
                new Category { Id = 4, Name = "Game Consoles", Image = "category-4.jpg", IsMain = true, IsDeleted = false },
                new Category { Id = 5, Name = "Bottoms", Image = "category-5.jpg", IsMain = true, IsDeleted = false },
                new Category { Id = 6, Name = "Tops & Sets", Image = "category-6.jpg", IsMain = true, IsDeleted = false },
                new Category { Id = 7, Name = "Audio & Video", Image = "category-7.jpg", IsMain = true, IsDeleted = false },
                new Category { Id = 8, Name = "Accessories", Image = "category-8.jpg", IsMain = true, IsDeleted = false },
                new Category { Id = 9, Name = "Camera", Image = "category-9.jpg", IsMain = true, IsDeleted = false },
                new Category { Id = 10, Name = "Video Games", Image = "category-10.jpg", IsMain = true, IsDeleted = false },
                new Category { Id = 11, Name = "Printer", Image = "category-11.jpg", IsMain = true, IsDeleted = false },
                new Category { Id = 12, Name = "Headphones", Image = "category-12.jpg", IsMain = true, IsDeleted = false }
            );
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage { Id=1,Image= "product-1.jpg", ProductId=1},
                new ProductImage { Id = 2, Image = "product-2.jpg", ProductId = 1 },
                new ProductImage { Id = 3, Image = "product-10.jpg", ProductId = 2 },
                new ProductImage { Id = 4, Image = "product-11.jpg", ProductId = 2 },
                new ProductImage { Id = 5, Image = "product-3.jpg", ProductId = 3 },
                new ProductImage { Id = 6, Image = "product-4.jpg", ProductId = 3 },
                new ProductImage { Id = 7, Image = "product-12.jpg", ProductId = 4 },
                new ProductImage { Id = 8, Image = "product-5.jpg", ProductId = 5 },
                new ProductImage { Id = 9, Image = "product-16.jpg", ProductId = 6 },
                new ProductImage { Id = 10, Image = "product-6.jpg", ProductId = 6 },
                new ProductImage { Id = 11, Image = "product-6.jpg", ProductId = 7 },
                new ProductImage { Id = 12, Image = "product-7.jpg", ProductId = 7 },
                new ProductImage { Id = 13, Image = "product-13.jpg", ProductId = 8 },
                new ProductImage { Id = 14, Image = "product-8.jpg", ProductId = 9 },
                new ProductImage { Id = 15, Image = "product-14.jpg", ProductId = 10 },
                new ProductImage { Id = 16, Image = "product-15.jpg", ProductId = 10 },
                new ProductImage { Id = 17, Image = "product-3.jpg", ProductId = 11 },
                new ProductImage { Id = 18, Image = "product-9.jpg", ProductId = 11 },
                new ProductImage { Id = 19, Image = "product-9.jpg", ProductId = 12 }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product {Id=1, Title= "Cale 6 eu accumsan massa facilisis Madden by Steve", Price=11.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=2, Title= "Winter Jacket eu accumsan massa facili originals Kaval Wind breaker", Price=23.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=3, Title= "Originals Kaval Wind breaker Winter Jacket eu...", Discount=23.90,Price=21.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=4, Title= "Juicy Couture Juicy Quilted Terry Track Jacket eu...",Price=35.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=5, Title= "Madden by Steve Madden Cale 6 eu accumsan massa...", Price=11.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=6, Title= "Trans-Weight Hooded Wind and Water Resistant Shell", Price=11.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=7, Title= "Water and Wind Resistant Insulated Jacket eu massa", Price=11.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=8, Title= "New Balance Fresh Foam Kaymin eu accumsan massa...", Price=11.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=9, Title= "Juicy Couture Solid Sleeve Puffer Jacket eu accumsan..", Price=18.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=10, Title= "New Balance Fresh Foam LAZR v1 Sport eu accumsan...", Price=18.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=11, Title= "Cale 6 eu accumsan massa facilisis Madden by Steve", Price=29.90,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false },
                new Product {Id=12, Title= "New Balance Arishi Sport v1Couture Juicy eu", Discount=29.00,Price=26.10,Code= "abcd1234",Description= "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",Rate=5,SaleCount=1,ExTax= 3.00,Brand= "Brac",Tags= "drone, camera",IsDeleted=false }
            );
        }
    }
}
