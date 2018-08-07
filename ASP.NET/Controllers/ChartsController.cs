using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;
using ASP.NET.Models;
using Newtonsoft.Json;
using System.Data.Entity;

namespace ASP.NET.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Home
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();

        }
        // GET: Home
        [AllowAnonymous]
        public ActionResult Statistics()
        {
                return View();
        }
    }
}