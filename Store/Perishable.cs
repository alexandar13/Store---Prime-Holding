using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Perishable : Product
    {
        protected DateTime expirationDate { get; set; }
        
        public Perishable(string name, string brand, double price, DateTime expirationDate) : base(name, brand, price)
        {
            this.expirationDate = expirationDate;
        }
        public override double getDiscount(DateTime timeOfPurchase)
        {
            if ((this.expirationDate - timeOfPurchase).Days == 0)
            {
                return price / 2;
            }
            if ((this.expirationDate-timeOfPurchase).Days <= 5)
            {
                return price / 10;
            }
     
            return 0;
        }
    }
}
