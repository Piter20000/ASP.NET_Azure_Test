using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET.Models;
using ASP.NET.Models.Helpers;
using Microsoft.AspNet.Identity;
using PC_Admin_Panel.Classes;

namespace ASP.NET.Controllers
{
    public class PaymentController : Controller
    {
        #region DB Connection

        private ApplicationDbContext _context;

        public PaymentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        #endregion

        // GET: Payment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User_Informations user_informations)
        {
            
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Orders_Informations", "Shop");
            }
            

            Session["User_Informations"] = user_informations;

            var ShoppItems = (List<Shopping_Cart>) Session["Shopping_Cart"];

            var sum = 0.00;

            foreach (var item in ShoppItems)
            {
                sum += item.Total_Price;
            }

            Session["Total_Price"] = sum*100;

            return View(user_informations);
        }

        // GET: Call_Back_RazorPay
        [HttpPost]
        public ActionResult Call_Back_RazorPay(string razorpay_payment_id)
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
                    Quantity = item.Quantity,
                    RazorPayID = razorpay_payment_id
                };
                _context.Order.Add(Item);
                _context.SaveChanges();

                string message = $"Hello {user_informations.Fname}! <br/> We've just received your paiment for <b>{item.Name}</b>, RazorPaiID: <b>{razorpay_payment_id}</b>!<br /> Thank's for your shopping!";
                string subject = "Information about payment";

                Send_Mail.Mail("piotr.murdzia.csharp.testy@gmail.com", User.Identity.GetUserName(), message, subject);
            }

            // Clear Session 
            Session["Shopping_Cart"] = null;
            Session["User_Informations"] = null;
            Session["Total_Price"] = null;

            // Set message 
            Session["Message"] = "Congratulations! You just bought in our shop, we send e-mail with more informations!";

            return RedirectToAction("Information", "Shop");

            return View();
        }
    }
}