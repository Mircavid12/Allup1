﻿// <auto-generated />
using System;
using Allup.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Allup.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Allup.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "category-1.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            Image = "category-2.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Computer"
                        },
                        new
                        {
                            Id = 3,
                            Image = "category-3.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Smartphone"
                        },
                        new
                        {
                            Id = 4,
                            Image = "category-4.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Game Consoles"
                        },
                        new
                        {
                            Id = 5,
                            Image = "category-5.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Bottoms"
                        },
                        new
                        {
                            Id = 6,
                            Image = "category-6.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Tops & Sets"
                        },
                        new
                        {
                            Id = 7,
                            Image = "category-7.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Audio & Video"
                        },
                        new
                        {
                            Id = 8,
                            Image = "category-8.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Accessories"
                        },
                        new
                        {
                            Id = 9,
                            Image = "category-9.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Camera"
                        },
                        new
                        {
                            Id = 10,
                            Image = "category-10.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Video Games"
                        },
                        new
                        {
                            Id = 11,
                            Image = "category-11.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Printer"
                        },
                        new
                        {
                            Id = 12,
                            Image = "category-12.jpg",
                            IsDeleted = false,
                            IsMain = true,
                            Name = "Headphones"
                        });
                });

            modelBuilder.Entity("Allup.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<double>("ExTax")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("SaleCount")
                        .HasColumnType("int");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 0.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 11.9,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "Cale 6 eu accumsan massa facilisis Madden by Steve"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 0.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 23.899999999999999,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "Winter Jacket eu accumsan massa facili originals Kaval Wind breaker"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 23.899999999999999,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 21.899999999999999,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "Originals Kaval Wind breaker Winter Jacket eu..."
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 0.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 35.899999999999999,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "Juicy Couture Juicy Quilted Terry Track Jacket eu..."
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 0.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 11.9,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "Madden by Steve Madden Cale 6 eu accumsan massa..."
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 0.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 11.9,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "Trans-Weight Hooded Wind and Water Resistant Shell"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 0.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 11.9,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "Water and Wind Resistant Insulated Jacket eu massa"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 0.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 11.9,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "New Balance Fresh Foam Kaymin eu accumsan massa..."
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 0.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 18.899999999999999,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "Juicy Couture Solid Sleeve Puffer Jacket eu accumsan.."
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 0.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 18.899999999999999,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "New Balance Fresh Foam LAZR v1 Sport eu accumsan..."
                        },
                        new
                        {
                            Id = 11,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 0.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 29.899999999999999,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "Cale 6 eu accumsan massa facilisis Madden by Steve"
                        },
                        new
                        {
                            Id = 12,
                            Brand = "Brac",
                            Code = "abcd1234",
                            Count = 0,
                            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.",
                            Discount = 29.0,
                            ExTax = 3.0,
                            IsDeleted = false,
                            Price = 26.100000000000001,
                            Rate = 5,
                            SaleCount = 1,
                            Tags = "drone, camera",
                            Title = "New Balance Arishi Sport v1Couture Juicy eu"
                        });
                });

            modelBuilder.Entity("Allup.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Allup.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "product-1.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Image = "product-2.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            Image = "product-10.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 4,
                            Image = "product-11.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 5,
                            Image = "product-3.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 6,
                            Image = "product-4.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 7,
                            Image = "product-12.jpg",
                            ProductId = 4
                        },
                        new
                        {
                            Id = 8,
                            Image = "product-5.jpg",
                            ProductId = 5
                        },
                        new
                        {
                            Id = 9,
                            Image = "product-16.jpg",
                            ProductId = 6
                        },
                        new
                        {
                            Id = 10,
                            Image = "product-6.jpg",
                            ProductId = 6
                        },
                        new
                        {
                            Id = 11,
                            Image = "product-6.jpg",
                            ProductId = 7
                        },
                        new
                        {
                            Id = 12,
                            Image = "product-7.jpg",
                            ProductId = 7
                        },
                        new
                        {
                            Id = 13,
                            Image = "product-13.jpg",
                            ProductId = 8
                        },
                        new
                        {
                            Id = 14,
                            Image = "product-8.jpg",
                            ProductId = 9
                        },
                        new
                        {
                            Id = 15,
                            Image = "product-14.jpg",
                            ProductId = 10
                        },
                        new
                        {
                            Id = 16,
                            Image = "product-15.jpg",
                            ProductId = 10
                        },
                        new
                        {
                            Id = 17,
                            Image = "product-3.jpg",
                            ProductId = 11
                        },
                        new
                        {
                            Id = 18,
                            Image = "product-9.jpg",
                            ProductId = 11
                        },
                        new
                        {
                            Id = 19,
                            Image = "product-9.jpg",
                            ProductId = 12
                        });
                });

            modelBuilder.Entity("Allup.Models.Category", b =>
                {
                    b.HasOne("Allup.Models.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Allup.Models.ProductCategory", b =>
                {
                    b.HasOne("Allup.Models.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Allup.Models.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Allup.Models.ProductImage", b =>
                {
                    b.HasOne("Allup.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
