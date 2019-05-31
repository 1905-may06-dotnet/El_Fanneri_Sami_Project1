using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Data
{
    public static class OrdersMapper
    {
        public static Data.Entities.Orders Map(Domain.Orders dmOrders)
        {
            Data.Entities.Orders deOrders = new Entities.Orders();

            deOrders.Id = dmOrders.Id;
            deOrders.OrderCost = dmOrders.OrderCost;
            deOrders.LocationId = dmOrders.LocationId;
            deOrders.UserId = dmOrders.UserId;

            return deOrders;
        }

        public static Domain.Orders Map(Data.Entities.Orders deUser) => new Domain.Orders
        {
            Id = deUser.Id,
            OrderCost = deUser.OrderCost,
            LocationId = deUser.LocationId,
            UserId = deUser.UserId
        };
    }
}
