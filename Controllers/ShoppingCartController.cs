using Microsoft.AspNetCore.Mvc;
using Projet.ASP.NET.Core.MVC.Models;
using Projet.ASP.NET.Core.MVC.Repository;
using Projet.ASP.NET.Core.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IBookRepository bookRepository, ShoppingCart shoppingCart)
        {
            _bookRepository = bookRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var shoppingCartViewModel = new ShoppingCartViewModel();
            shoppingCartViewModel.ShoppingCart = _shoppingCart;
            shoppingCartViewModel.ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal();
            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToShoppingCart(int idBook)
        {
            var book = _bookRepository.GetBookById(idBook);
            if (book!=null)
            {
                _shoppingCart.AddToCart(book, 1);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int idBook)
        {
            var book = _bookRepository.GetBookById(idBook);
            if (book != null)
            {
                _shoppingCart.RemoveFromCart(book);
            }
            return RedirectToAction("Index");
        }
    }
}
