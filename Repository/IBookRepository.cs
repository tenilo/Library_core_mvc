using Projet.ASP.NET.Core.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
    }
}
