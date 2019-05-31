using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public int OrderCost { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }

        public virtual Location Location { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
