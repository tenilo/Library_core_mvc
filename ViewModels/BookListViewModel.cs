using Projet.ASP.NET.Core.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }

}
