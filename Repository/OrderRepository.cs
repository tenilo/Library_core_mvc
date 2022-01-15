using Projet.ASP.NET.Core.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Repository
{
    public class OrderRepository : IOderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;
        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlace = DateTime.Now;
            var items = _shoppingCart.GetShoppingCartItems();
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            order.OrderDetails = new List<OrderDetail>();
            foreach (var item in items)
            {
                //pour chaque item de la liste on ajoute un detail
                var orderDetail = new OrderDetail
                {
                    BookId = item.Book.BooKId,
                    Amount = item.Amount,
                    Price = item.Book.Price
                };
                order.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

        }
    }
}
