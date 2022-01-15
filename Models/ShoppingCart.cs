using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        //chaque utilisateur à une session, on crée danc la propriété 
        public string ShoppingCartSessionID { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public static ShoppingCart GetCart(IServiceProvider service)
        {
            // on crée la session de l'utilisateur
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            // on crée le context
            var context = service.GetService<AppDbContext>();
            /*On verifie si l'utilisateur a une session ou s'il n'a pas de session et que c'est la premiere fois 
             qu'il visite le site, on le crée une session*/
            var sessionCart = session.GetString("cartIdSession") ?? Guid.NewGuid().ToString();
            session.SetString("cartIdSession", sessionCart);
            // on recupere une intance de la classe ShoppingCart avec la session correspondante
            return new ShoppingCart(context) { ShoppingCartSessionID = sessionCart };
        }
        public void AddToCart (Book book, int amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.FirstOrDefault(item => item.ShoppingCartSessionId == ShoppingCartSessionID && item.Book.BooKId == book.BooKId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartSessionId = ShoppingCartSessionID,
                    Book = book,
                    Amount = 1
                };
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }
        public int RemoveFromCart(Book book)
        {
            var shoppingCartItem =
                       _appDbContext.ShoppingCartItems.SingleOrDefault(
                           s => s.Book.BooKId == book.BooKId && s.ShoppingCartSessionId == ShoppingCartSessionID);
            var localAmount = 0;
            if (shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _appDbContext.SaveChanges();
            return localAmount;
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems??
                   (ShoppingCartItems =
                   _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartSessionId == ShoppingCartSessionID)
                   .Include(s => s.Book)
                   .ToList());
        }
        public void ClearCart()
        {
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartSessionId == ShoppingCartSessionID);
            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }
        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartSessionId == ShoppingCartSessionID)
                .Select(c => c.Book.Price * c.Amount).Sum();
            return total;
        }
    }
}
