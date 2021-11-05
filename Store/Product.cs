using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public abstract class Product
    {
        #region Attributes
        protected string name { get; set; }
        protected string brand { get; set; }
        protected double price { get; set; }

        #endregion

        #region Constructors
        public Product(string name, string brand, double price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
        }

        #endregion

        #region Methods
        public abstract double getDiscount(DateTime timeOfPurchase);

        public string getName()
        {
            return name;
        }

        public double getPrice()
        {
            return price;
        }

        public string getBrand()
        {
            return brand;
        }
        #endregion
    }
}
