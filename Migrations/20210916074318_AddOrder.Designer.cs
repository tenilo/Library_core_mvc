﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projet.ASP.NET.Core.MVC.Models;

namespace Projet.ASP.NET.Core.MVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210916074318_AddOrder")]
    partial class AddOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projet.ASP.NET.Core.MVC.Models.Book", b =>
                {
                    b.Property<int>("BooKId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageurUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BooKId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BooKId = 1,
                            CategoryId = 1,
                            ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/51p6wBow%2B3L._SX389_BO1,204,203,200_.jpg",
                            InStock = true,
                            LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                            Name = "Big Data for Dummies",
                            Price = 98m,
                            ShortDescription = "big data management is one of the major"
                        },
                        new
                        {
                            BooKId = 2,
                            CategoryId = 1,
                            ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/41JjodHnKHL._SX331_BO1,204,203,200_.jpg",
                            InStock = true,
                            LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                            Name = "Big Data",
                            Price = 120.90m,
                            ShortDescription = "Bernard Marr's Data strategy is a must-have guide to creating a robust data strategy"
                        },
                        new
                        {
                            BooKId = 3,
                            CategoryId = 2,
                            ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/51UvR3a63OL._SX379_BO1,204,203,200_.jpg",
                            InStock = true,
                            LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                            Name = "Data Engineering",
                            Price = 66m,
                            ShortDescription = "This book has been an evolving dream of ours for about five years."
                        },
                        new
                        {
                            BooKId = 4,
                            CategoryId = 2,
                            ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/51gP9mXEqWL._SX379_BO1,204,203,200_.jpg",
                            InStock = true,
                            LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                            Name = "Data-Intensive",
                            Price = 66m,
                            ShortDescription = "The big ideas behind reliable, scalable, and maintainable systems"
                        },
                        new
                        {
                            BooKId = 5,
                            CategoryId = 3,
                            ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/51gP9mXEqWL._SX379_BO1,204,203,200_.jpg",
                            InStock = true,
                            LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                            Name = "Angular",
                            Price = 66m,
                            ShortDescription = "The big ideas behind reliable, scalable, and maintainable systems"
                        },
                        new
                        {
                            BooKId = 6,
                            CategoryId = 3,
                            ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/51Q43WRXJzL.jpg",
                            InStock = true,
                            LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                            Name = "Learning React",
                            Price = 89m,
                            ShortDescription = "Developped by facebook, and used by companies including netflix"
                        },
                        new
                        {
                            BooKId = 7,
                            CategoryId = 4,
                            ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/413Z89zzezL._SX348_BO1,204,203,200_.jpg",
                            InStock = true,
                            LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                            Name = "Pro C# 7",
                            Price = 55.60m,
                            ShortDescription = "Dive in and discover why pro c# has been a favorite"
                        },
                        new
                        {
                            BooKId = 8,
                            CategoryId = 4,
                            ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/41NGBmeH1uL._SX403_BO1,204,203,200_.jpg",
                            InStock = true,
                            LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                            Name = "Learning Node.js",
                            Price = 98m,
                            ShortDescription = "Dive in and discover why pro c# has been a favorite"
                        });
                });

            modelBuilder.Entity("Projet.ASP.NET.Core.MVC.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Big data",
                            Description = "books of big data"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Database",
                            Description = "books of database"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Front-End",
                            Description = "books of Front-End"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Back-End",
                            Description = "books of Back-End"
                        });
                });

            modelBuilder.Entity("Projet.ASP.NET.Core.MVC.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlace")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Projet.ASP.NET.Core.MVC.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Projet.ASP.NET.Core.MVC.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("BooKId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartSessionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("BooKId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Projet.ASP.NET.Core.MVC.Models.Book", b =>
                {
                    b.HasOne("Projet.ASP.NET.Core.MVC.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projet.ASP.NET.Core.MVC.Models.OrderDetail", b =>
                {
                    b.HasOne("Projet.ASP.NET.Core.MVC.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet.ASP.NET.Core.MVC.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projet.ASP.NET.Core.MVC.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Projet.ASP.NET.Core.MVC.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BooKId");
                });
#pragma warning restore 612, 618
        }
    }
}