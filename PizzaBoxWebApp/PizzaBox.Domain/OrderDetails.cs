using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string PizzaCost { get; set; }
        public int OrderId { get; set; }
    }
}
