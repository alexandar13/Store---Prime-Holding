using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Cashier
    {
        #region Constructors
        public Cashier()
        {
        }

        #endregion

        #region Methods
        public void printReceipt(Cart cart, DateTime timeOfPurchase)
        {
            Console.WriteLine("Date: " + timeOfPurchase.ToString());
            Console.WriteLine("\n--Products--");

            cart.printProducts(timeOfPurchase);
            Console.WriteLine("-------------------------------\n");
            
            double discount = cart.getDiscount(timeOfPurchase);
            double subtotal = cart.getSubtotal();

            Console.WriteLine("SUBTOTAL: " + Math.Round(subtotal, 2));
            Console.WriteLine("DISCOUNT: -" + Math.Round(discount, 2));
            Console.WriteLine("\nTOTAL: " + Math.Round((subtotal - discount), 2));
        }

        #endregion
    }
}
