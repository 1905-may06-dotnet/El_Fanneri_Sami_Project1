using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Data
{
    public static class LocationMapper
    {
        public static Data.Entities.Location Map(Domain.Location dmLocation)
        {
            Data.Entities.Location deLocation = new Entities.Location();

            deLocation.Id = dmLocation.Id;
            deLocation.Street = dmLocation.Street;
            deLocation.City = dmLocation.City;
            deLocation.State = dmLocation.State;
            deLocation.ZipCode = dmLocation.ZipCode;
            deLocation.Phone = dmLocation.Phone;
            //deLocation.Orders = dmLocation.Orders;

            return deLocation;
        }

        public static Domain.Location Map(Data.Entities.Location deLocation) => new Domain.Location
        {
            Id = deLocation.Id,
            Street = deLocation.Street,
            City = deLocation.City,
            State = deLocation.State,
            ZipCode = deLocation.ZipCode,
            Phone = deLocation.Phone
        };
    }
}
