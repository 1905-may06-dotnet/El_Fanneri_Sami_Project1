using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public interface IUsersRepository
    {
        void AddUser(Users user);
        void EditUser(Users user);
        void RemoveUser(int Id);
        Users GetUserByName(string lastName);
        IEnumerable<Users> GetUsers();
        void Save();
    }
}
