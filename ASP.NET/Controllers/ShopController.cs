using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET.Models;
using ASP.NET.Models.Helpers;
using Microsoft.AspNet.Identity;
using PC_Admin_Panel.Classes;
using System.Data.Entity;

namespace ASP.NET.Controllers
{
    public class ShopController : Controller
    {
        #region DB Connection

        private ApplicationDbContext _context;

        public ShopController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        #endregion

        // GET: Shop
        [AllowAnonymous]
        public ActionResult Index()
        {
            var Shop_Items_List = _context.ShopItem.ToList();

            return View(Shop_Items_List);
        }

        // GET: New Item
        public ActionResult New_Item()
        {
            return View();
        }

        // GET: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Shop_Item Item)
        {
            if (ModelState.IsValid)
            {
                // Set DateTime from server 
                Item.Created = DateTime.Now;

                // Initial local instance of DB item
                _context.ShopItem.Add(Item);
                // Update DB
                _context.SaveChanges();

                // Set message 
                Session["Message"] = $"Congratulations! Item is just added into shop! ";

                // Return to Information page
                return RedirectToAction("Information", "Shop");
            }

            return RedirectToAction("New_Item", "Shop");
        }

        // GET: Information
        public ActionResult Information()
        {
            return View();
        }

        // GET: Shopping Cart
        [AllowAnonymous]
        public ActionResult ShoppingCart()
        {
            return View();
        }

        // GET: Order Informations
        public ActionResult Orders_Informations()
        {
            // Copy lats used User Informations ID
            var Last_ID = User_Informations_Helper.Get_ID(User.Identity.GetUserId());

            // Create copy of User Informations
            var User_Info = _context.User_Informationses.SingleOrDefault(x => x.id == Last_ID);

            if (User_Info != null)
                Session["User_Informations"] = User_Info;
            else
                Session["User_Informations"] = new User_Informations();


            return View();
        }

        // GET: Order
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Order()
        {
            if (Session["User_Informations"] == null || Session["Shopping_Cart"] == null)
            {
                return RedirectToAction("ShoppingCart", "Shop");
            }

            var user_informations = (User_Informations)Session["User_Informations"];

            // Add User Informations into DB
            User_Informations_Helper.Update(user_informations);

            int id = User_Informations_Helper.Get_ID(User.Identity.GetUserId());

            var shoppingCartList = (List<Shopping_Cart>)Session["Shopping_Cart"];

            foreach (var item in shoppingCartList)
            {
                var Item = new Order()
                {
                    UID = @User.Identity.GetUserId(),
                    Ordered = DateTime.Now,
                    Paid = DateTime.Now,
                    Delivered = DateTime.Now,
                    UserInformationsID = id,
                    ShopItemID = item.ID,
                    Quantity = item.Quantity
                };
                    _context.Order.Add(Item);
                    _context.SaveChanges();

                string message = $"Hello {user_informations.Fname}! <br/> We've just received your Order for <b>{item.Name}</b>! <br /> Thank you!";
                string subject = "Information about order";

                Send_Mail.Mail("piotr.murdzia.csharp.testy@gmail.com", User.Identity.GetUserName(), message, subject);
            }

            // Clear Session 
            Session["Shopping_Cart"] = null;
            Session["User_Informations"] = null;
            Session["Total_Price"] = null;

            // Set message 
            Session["Message"] = $"Congratulations! You just ordered item, we send e-mail!";

            return RedirectToAction("Information", "Shop");
        }

        public ActionResult Orders()
        {
            var orders = _context.Order.Include(X=>X.ShopItem).ToList();

            return View(orders);
        }
    }
}