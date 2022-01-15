using Projet.ASP.NET.Core.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Repository
{
    public class MookBookRepository : IBookRepository
    {
        private readonly ICategoryRepository _category = new MookCategoryRepository();

        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>()
            {
                new Book{BooKId=1, Name="Big data for Dummies", LongDescription="management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", ShortDescription="big data management is one of the major ", ImageurUrl="https://images-na.ssl-images-amazon.com/images/I/51p6wBow%2B3L._SX389_BO1,204,203,200_.jpg", InStock=true, Price=98, CategoryId=1, Category=_category.GetCategoryById(1)},
                new Book{BooKId=2, Name="Big data", LongDescription="management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", ShortDescription="Bernard marr's data strategy ", ImageurUrl="https://images-na.ssl-images-amazon.com/images/I/41JjodHnKHL._SX331_BO1,204,203,200_.jpg", InStock=true, Price=120.90M, CategoryId=1, Category=_category.GetCategoryById(1)},
                new Book{BooKId=3, Name="Database Engineering ", LongDescription="management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", ShortDescription="This book has been an ecolving dream of ours ", ImageurUrl="https://images-na.ssl-images-amazon.com/images/I/51UvR3a63OL._SX379_BO1,204,203,200_.jpg", InStock=true, Price=66, CategoryId=2, Category=_category.GetCategoryById(2)},
                new Book{BooKId=4, Name="Data-Intensive ", LongDescription="management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", ShortDescription="The big ideas behind reliable ", ImageurUrl="https://images-na.ssl-images-amazon.com/images/I/51gp9mXEqWL._SX379_BO1,204,203,200_.jpg", InStock=true, Price=66, CategoryId=2, Category=_category.GetCategoryById(2)},
                new Book{BooKId=5, Name="Angular ", LongDescription="management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", ShortDescription="The big ideas behind reliable, scalable, and maintainable systems ", ImageurUrl="https://images-na.ssl-images-amazon.com/images/I/51gp9mXEqWL._SX379_BO1,204,203,200_.jpg", InStock=true, Price=66, CategoryId=3, Category=_category.GetCategoryById(3)},
                new Book{BooKId=6, Name="Learning react ", LongDescription="management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", ShortDescription="Developed by facebook, and used by companies including netflix ", ImageurUrl="https://images-na.ssl-images-amazon.com/images/I/51Q43WRXJzL.jpg", InStock=true, Price=89, CategoryId=3, Category=_category.GetCategoryById(3)},
                new Book{BooKId=7, Name="Pro c# ", LongDescription="management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", ShortDescription="Dive in and discover why pro c# has been a favorite", ImageurUrl="https://images-na.ssl-images-amazon.com/images/I/413Z89zzezL._SX348_BO1,204,203,200_.jpg", InStock=true, Price=55.60M, CategoryId=4, Category=_category.GetCategoryById(4)},
                new Book{BooKId=8, Name="Learning Node.js ", LongDescription="management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", ShortDescription="Learning the fundamentals of node.js, and deploy and test", ImageurUrl="https://images-na.ssl-images-amazon.com/images/I/41NGBmeH1uL._SX403_BO1,204,203,200_.jpg", InStock=true, Price=98, CategoryId=4, Category=_category.GetCategoryById(4)},
            };
        }

        public Book GetBookById(int id)
        {
            return GetAllBooks().FirstOrDefault(b=>b.BooKId==id);
        }
    }
}
