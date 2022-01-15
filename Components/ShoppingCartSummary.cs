using Microsoft.AspNetCore.Mvc;
using Projet.ASP.NET.Core.MVC.Models;
using Projet.ASP.NET.Core.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Components
{
    /*Components est utilisé pour interagir directement sur la par exemple lorsqu'un client clique
     sur ajouter un livre, on doit voir automatiquement le panier augmenter de 1*/
    public class ShoppingCartSummary : ViewComponent
    {
        /*ici ce sont les données de la base des données dont on a besoin
         c'est également le dependency injection*/
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel();
            shoppingCartViewModel.ShoppingCart = _shoppingCart;
            shoppingCartViewModel.ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal();
            return View(shoppingCartViewModel);
        }
    }
}
