using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public interface IOrderDetailsRepository
    {
        IEnumerable<Domain.OrderDetails> ShowOrderDetailByUserId(int id);
        IEnumerable<Domain.OrderDetails> ShowOrderDetail();
        void Save();
    }
}
