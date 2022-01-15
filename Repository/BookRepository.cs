using Microsoft.EntityFrameworkCore;
using Projet.ASP.NET.Core.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

            
        public IEnumerable<Book> GetAllBooks()
           
        {
            // on inclut categories dans la recupération des livres
           return _appDbContext.Books.Include(c => c.Category);
        }

        public Book GetBookById(int id)
        {
            return _appDbContext.Books.FirstOrDefault(b => b.BooKId == id);
        }
    }
}
