using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Data
{
    public class OrderDetailsMapper
    {
        public static Data.Entities.OrderDetails Map(Domain.OrderDetails dmOrderDetails)
        {
            Data.Entities.OrderDetails deOrderDetails = new Entities.OrderDetails();

            deOrderDetails.Id = dmOrderDetails.Id;
            deOrderDetails.PizzaName = dmOrderDetails.PizzaName;
            deOrderDetails.Size = dmOrderDetails.Size;
            deOrderDetails.Crust = dmOrderDetails.Crust;
            deOrderDetails.PizzaCost = dmOrderDetails.PizzaCost;
            deOrderDetails.OrderId = dmOrderDetails.OrderId;
            
            return deOrderDetails;
        }

        public static Domain.OrderDetails Map(Data.Entities.OrderDetails deOrderDetails) => new Domain.OrderDetails
        {
            Id = deOrderDetails.Id,
            PizzaName = deOrderDetails.PizzaName,
            Size = deOrderDetails.Size,
            Crust = deOrderDetails.Crust,
            PizzaCost = deOrderDetails.PizzaCost,
            OrderId = deOrderDetails.OrderId
            
        };
    }
}
