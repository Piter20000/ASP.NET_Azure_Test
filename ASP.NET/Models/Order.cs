using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public string UID { get; set; }

        public DateTime Ordered { get; set; }

        public DateTime Paid { get; set; }

        public DateTime Delivered { get; set; }

        public User_Informations UserInformations { get; set; }

        public int UserInformationsID { get; set; }

        public Shop_Item ShopItem { get; set; }

        public int ShopItemID { get; set; }

        public int Quantity { get; set; }

        public string RazorPayID { get; set; }
    }
}