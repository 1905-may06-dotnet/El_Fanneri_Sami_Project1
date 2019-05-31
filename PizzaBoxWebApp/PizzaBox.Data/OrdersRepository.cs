using PizzaBox.Data.Entities;
using PizzaBox.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using OrderDetails = PizzaBox.Domain.OrderDetails;

namespace PizzaBox.Data
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly ContextDb _db;
        public OrdersRepository(ContextDb db)
        {
            _db = db;
        }

        public int GetTotalCost(List<OrderDetails> orderDetail)  
        {
            int cost = 0;

            foreach (var order in orderDetail)
            {
                cost = cost + int.Parse(order.PizzaCost);
            }

            return cost;
        }

    }
}
