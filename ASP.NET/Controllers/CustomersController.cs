using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET.Models;

namespace ASP.NET.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Authorize(Roles = Role_Name.CanManageShopsItems)]
        public ActionResult Index()
        {
            var customersList = new List<Customer>();

            using (var context = new ApplicationDbContext())
            {
                var Users = context.Users.ToList();

                foreach (var user in Users)
                {
                    customersList.Add(new Customer()
                    {
                        ID = user.Id,
                        Name = user.UserName
                    });
                }
            }

            return View((IEnumerable<Customer>)customersList);
        } 
    }
}