using PizzaBox.Data.Entities;
using PizzaBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBox.Data
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ContextDb _db;
        public LocationRepository(ContextDb db)
        {
            _db = db;
        }

        public Domain.Location GetLocationByCity(string city)
        {
            var element = _db.Location.Where(i => i.City.Contains(city)).FirstOrDefault();

            if (element != null)
                return LocationMapper.Map(element);
            else
                return null;
        }

        public IEnumerable<Domain.Location> GetLocations()
        {
            return _db.Location.Select(x => LocationMapper.Map(x));
        }
    }
}
