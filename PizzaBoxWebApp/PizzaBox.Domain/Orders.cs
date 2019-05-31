using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class Orders
    {
        public int Id { get; set; }
        public int OrderCost { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }
    }
}
