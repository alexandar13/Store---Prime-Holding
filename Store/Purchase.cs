using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Purchase
    {
        #region Attributes
        private Product product { get; set; }
        private double quantity { get; set; }

        #endregion

        #region Constructors
        public Purchase(Clothe clothe, int quantity)
        {
            this.product = clothe;
            this.quantity = quantity;
        }

        public Purchase(Food food, double quantity)
        {
            this.product = food;
            this.quantity = quantity;
        }

        public Purchase(Beverage beverage, int quantity)
        {
            this.product = beverage;
            this.quantity = quantity;
        }

        public Purchase(Appliance appliance, int quantity)
        {
            this.product = appliance;
            this.quantity = quantity;
        }

        #endregion

        #region Methods

        public double getDiscount(DateTime timeOfPurchase)
        {
            return product.getDiscount(timeOfPurchase) * quantity;
        }

        public void print(DateTime timeOfPurchase)
        {
            Console.WriteLine("\n");
            Console.WriteLine(product.getName() + " " + product.getBrand());
            Console.WriteLine(quantity.ToString() + " x $" + product.getPrice() + " = $" + Math.Round(product.getPrice() * quantity, 2));
            
            double discount = product.getDiscount(timeOfPurchase);

            if (discount > 0) 
            {

                Console.WriteLine("#discount " + discount / product.getPrice() * 100 + "% " + " -$" + Math.Round(discount*quantity, 2));
            }
            
        }

        public double getPrice()
        {
            return product.getPrice() * quantity;
        }
        #endregion
    }
}
