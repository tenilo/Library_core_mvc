using Microsoft.AspNetCore.Mvc;
using Projet.ASP.NET.Core.MVC.Repository;
using Projet.ASP.NET.Core.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Controllers
{
    /* On crée le controleur que nous allons utiliser comme page d'accueil
     car dans le routage par défaut, il est defini Home comme controleur et Index pour l'action*/
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            var listBook = new BookListViewModel();
            //on recupere trois livres dans la liste des books
            listBook.Books = _bookRepository.GetAllBooks().Take(3);
            return View(listBook);
        }
    }
}
