using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace ASP.NET.Models
{
    public class Charts
    {
        public List<Charts> List { get; set; }

        public int Quantity { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="Quantity"></param>
        /// <param name="Name"></param>
        /// <param name="ID"></param>
        public Charts(int Quantity, string Name, int ID)
        {
            this.Quantity = Quantity;
            this.Name = Name;
            this.ID = ID;
        }
    }
}