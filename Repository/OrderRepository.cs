using Jupiter.Context;
using Jupiter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jupiter.Repository
{
    public class OrderRepository : IOrderRepository
    {

        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }


        //  Uses the repositories to create both the order and it's order details
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            //adding the order with its details
            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    TitleId = shoppingCartItem.Title.Id,
                    Price = shoppingCartItem.Title.Id
                };

                order.OrderDetails.Add(orderDetail);
            }

            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}