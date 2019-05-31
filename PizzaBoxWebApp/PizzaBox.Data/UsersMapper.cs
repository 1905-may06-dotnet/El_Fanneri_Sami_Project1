using System;

namespace PizzaBox.Data
{
    public static class UsersMapper
    {
        public static Data.Entities.Users Map(Domain.Users dmUser)
        {
            Data.Entities.Users deUser = new Entities.Users();

            deUser.Id = dmUser.Id;
            deUser.FirstName = dmUser.FirstName;
            deUser.LastName = dmUser.LastName;
            deUser.Street = dmUser.Street;
            deUser.City = dmUser.City;
            deUser.State = dmUser.State;
            deUser.ZipCode = dmUser.ZipCode;
            deUser.Phone = dmUser.Phone;
            deUser.Email = dmUser.Email;
            deUser.Password = dmUser.Password;

            return deUser;
        }

        public static Domain.Users Map(Data.Entities.Users deUser) => new Domain.Users
        {
            Id = deUser.Id,
            FirstName = deUser.FirstName,
            LastName = deUser.LastName,
            Street = deUser.Street,
            City = deUser.City,
            State = deUser.State,
            ZipCode = deUser.ZipCode,
            Phone = deUser.Phone,
            Email = deUser.Email,
            Password = deUser.Password
        };
    }
}
