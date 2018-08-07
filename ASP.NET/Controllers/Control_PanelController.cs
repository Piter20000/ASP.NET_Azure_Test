using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET.Models;

namespace ASP.NET.Controllers
{
    public class Control_PanelController : Controller
    {
        // GET: Admin_Panel
        [Authorize(Roles = Role_Name.CanManageShopsItems)]
        public ActionResult Admin_Panel()
        {
            return View();
        }

        // GET: User_Panel
        public ActionResult User_Panel()
        {
            return View();
        }
    }
}