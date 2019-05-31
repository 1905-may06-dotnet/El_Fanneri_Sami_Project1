using System;
using System.Collections.Generic;

namespace PizzaBox.Domain
{
    public class Location
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
    }
}
