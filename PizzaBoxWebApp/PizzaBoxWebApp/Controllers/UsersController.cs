using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Domain;

namespace PizzaBoxWebApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersRepository db;

        public UsersController(IUsersRepository db)
        {
            this.db = db;
        }

        Models.Users u;
        List<Models.Users> userList = new List<Models.Users>();

        //GET : User
        public ActionResult Index()
        {
            var users = db.GetUsers();
            foreach (var user in users)
            {
                u = new Models.Users();
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.Email = user.Email;

                userList.Add(u);
            }

            return View(userList);
        }

        //GET : Users/SignUp
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        //POST : Users/SignUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(IFormCollection collection, Models.Users user)
        {
            PizzaBox.Domain.Users dmc = new Users();

            dmc.FirstName = user.FirstName;
            dmc.LastName = user.LastName;
            dmc.Street = user.Street;
            dmc.City = user.City;
            dmc.State = user.State;
            dmc.ZipCode = user.ZipCode;
            dmc.Phone = user.Phone;
            dmc.Email = user.Email;
            dmc.Password = user.Password;

            try
            {
                db.AddUser(dmc);
                db.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}