using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public interface ILocationRepository
    {
        Location GetLocationByCity(string city);
        IEnumerable<Location> GetLocations();
    }
}
