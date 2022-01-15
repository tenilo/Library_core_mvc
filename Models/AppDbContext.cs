using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        //le constructeur
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        //ci dessous les tables de notre projet
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // la base crée est vide on souhaite l'initialiser 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // hasdata pour si la base de données est vide, on ajoute l'intruction entre parenthèses
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Big data", Description = "books of big data" });
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 2, CategoryName = "Database", Description = "books of database" });
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 3, CategoryName = "Front-End", Description = "books of Front-End" });
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 4, CategoryName = "Back-End", Description = "books of Back-End" });

            modelBuilder.Entity<Book>().HasData(
                new Book 
                { BooKId = 1, 
                  Name = "Big Data for Dummies", 
                  LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                  ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/51p6wBow%2B3L._SX389_BO1,204,203,200_.jpg",
                  InStock = true,
                  ShortDescription = "big data management is one of the major",
                  Price = 98,
                  CategoryId = 1
                });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BooKId = 2,
                    Name = "Big Data",
                    LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                    ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/41JjodHnKHL._SX331_BO1,204,203,200_.jpg",
                    InStock = true,
                    ShortDescription = "Bernard Marr's Data strategy is a must-have guide to creating a robust data strategy",
                    Price = 120.90M,
                    CategoryId = 1
                });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BooKId = 3,
                    Name = "Data Engineering",
                    LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                    ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/51UvR3a63OL._SX379_BO1,204,203,200_.jpg",
                    InStock = true,
                    ShortDescription = "This book has been an evolving dream of ours for about five years.",
                    Price = 66,
                    CategoryId = 2
                });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BooKId = 4,
                    Name = "Data-Intensive",
                    LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                    ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/51gP9mXEqWL._SX379_BO1,204,203,200_.jpg",
                    InStock = true,
                    ShortDescription = "The big ideas behind reliable, scalable, and maintainable systems",
                    Price = 66,
                    CategoryId = 2
                });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BooKId = 5,
                    Name = "Angular",
                    LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                    ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/51gP9mXEqWL._SX379_BO1,204,203,200_.jpg",
                    InStock = true,
                    ShortDescription = "The big ideas behind reliable, scalable, and maintainable systems",
                    Price = 66,
                    CategoryId = 3
                });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BooKId = 6,
                    Name = "Learning React",
                    LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                    ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/51Q43WRXJzL.jpg",
                    InStock = true,
                    ShortDescription = "Developped by facebook, and used by companies including netflix",
                    Price = 89,
                    CategoryId = 3
                });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BooKId = 7,
                    Name = "Pro C# 7",
                    LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                    ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/413Z89zzezL._SX348_BO1,204,203,200_.jpg",
                    InStock = true,
                    ShortDescription = "Dive in and discover why pro c# has been a favorite",
                    Price = 55.60M,
                    CategoryId = 4
                });

            modelBuilder.Entity<Book>().HasData(
               new Book
               {
                   BooKId = 8,
                   Name = "Learning Node.js",
                   LongDescription = "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.",
                   ImageurUrl = "https://images-na.ssl-images-amazon.com/images/I/41NGBmeH1uL._SX403_BO1,204,203,200_.jpg",
                   InStock = true,
                   ShortDescription = "Dive in and discover why pro c# has been a favorite",
                   Price = 98,
                   CategoryId = 4
               });






        }
    }
}
