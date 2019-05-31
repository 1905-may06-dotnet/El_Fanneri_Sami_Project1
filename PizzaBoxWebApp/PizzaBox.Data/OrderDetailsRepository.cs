using PizzaBox.Data.Entities;
using PizzaBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBox.Data
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private readonly ContextDb _db;
        public OrderDetailsRepository(ContextDb db)
        {
            _db = db;
        }

        public IEnumerable<Domain.OrderDetails> ShowOrderDetailByUserId(int id)
        {
            yield return _db.OrderDetails.Select(x => OrderDetailsMapper.Map(x)).Where(i => i.Id == id).FirstOrDefault();
        }

        public IEnumerable<Domain.OrderDetails> ShowOrderDetail()
        {
            return _db.OrderDetails.Select(x => OrderDetailsMapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
