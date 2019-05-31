using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public interface IOrdersRepository
    {
        int GetTotalCost(List<OrderDetails> orderDetails);
    }
}
