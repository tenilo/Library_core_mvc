using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projet.ASP.NET.Core.MVC.Models;
using Projet.ASP.NET.Core.MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart; 
        public OrderController(IOderRepository oderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = oderRepository;
            _shoppingCart = shoppingCart;

        }
        public IActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count==0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some book first");
            }
            if(ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("ConfirmOrder");
            }
            return View(order);
        }
        public IActionResult ConfirmOrder()
        {
            return View();
        }
    }
}
