using PizzaBox.Data.Entities;
using PizzaBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBox.Data
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ContextDb _db;
        public UsersRepository(ContextDb db)
        {
            _db = db;
        }

        public void AddUser(Domain.Users user)
        {
            _db.Users.Add(UsersMapper.Map(user));
        }

        public void EditUser(Domain.Users user)
        {
            _db.Users.Update(UsersMapper.Map(user));
        }

        public void RemoveUser(int Id)
        {
            _db.Users.Remove(_db.Users.Find(Id));
        }

        public Domain.Users GetUserByName(string name)
        {
            var element = _db.Users.Where(i => i.FirstName.Contains(name) || i.LastName.Contains(name)).FirstOrDefault();

            if (element != null)
                return UsersMapper.Map(element);
            else
                return null;
        }

        public IEnumerable<Domain.Users> GetUsers()
        {
            return _db.Users.Select(x => UsersMapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
