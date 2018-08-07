using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET.Models
{
    public class Shopping_Cart
    {
        private int _id;
        private string _name;
        private int _quantity;
        private double _price;
        private double _total_price;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public double Total_Price
        {
            get { return _total_price; }
            set { _total_price = value; }
        }

        /// <summary>
        /// Defoult class constructor
        /// </summary>
        public Shopping_Cart()
        {

        }

        /// <summary>
        /// Basic class constructor
        /// </summary>
        /// <param name="Id"> Item ID </param>
        /// <param name="Name"> Item Name </param>
        /// <param name="Quantity"> Quantity </param>
        /// <param name="Price"> Price </param>
        public Shopping_Cart(int Id, string Name, int Quantity, double Price)
        {
            this.ID = Id;
            this.Name = Name;
            this.Quantity = Quantity;
            this.Price = Price;
            this.Total_Price = Price * Quantity;
        }

        /// <summary>
        /// Method update items data
        /// Passing onely quantity update quantity and 
        /// </summary>
        /// <param name="Quantity"> </param>
        public void UpdateShoppingCart(int Quantity)
        {
            this.Quantity += Quantity;
            this.Total_Price = this.Quantity * this.Price;
        }
    }
}