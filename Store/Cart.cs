using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Cart
    {
        #region Attributes

        List<Purchase> purchases;
        #endregion

        #region Constructors

        public Cart()
        {
            purchases = new List<Purchase>();
        }

        #endregion

        #region Methods
        public void addToCart(Purchase purchase)
        {
            purchases.Add(purchase);
        }

        public void printProducts(DateTime timeOfPurchase)
        {
            foreach (Purchase purchase in purchases)
            {
                purchase.print(timeOfPurchase);
            }

        }

        public double getSubtotal()
        {
            double subtotal = 0;
            foreach (Purchase purchase in purchases)
            {
                subtotal += purchase.getPrice();
            }
            return subtotal;
        }

        public double getDiscount(DateTime timeOfPurchase)
        {
            double discount = 0;
            foreach (Purchase purchase in purchases)
            {
                discount += purchase.getDiscount(timeOfPurchase);
            }
            return discount;
        }
        #endregion
    }
}
