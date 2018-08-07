using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET.Dtos
{
    public class Order_Dto
    {
        public int ID { get; set; }

        public DateTime Ordered { get; set; }

        public int UserInformationsID { get; set; }

        public int ShopItemID { get; set; }
    }
}