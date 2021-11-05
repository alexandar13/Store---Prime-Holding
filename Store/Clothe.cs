using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    enum Sizes
    {
        XS,
        S,
        M,
        L,
        XL
    }
    class Clothe : Product
    {
        #region Attributes
        private Sizes size { get; set; }
        private string color { get; set; }

        #endregion

        #region Constructors
        public Clothe(string color, Sizes size, string name, string brand, double price) : base(name, brand, price)
        {
            this.size = size;
            this.color = color;
        }

        #endregion

        #region Methods
        public override double getDiscount(DateTime timeOfPurchase)
        {
            if(timeOfPurchase.DayOfWeek != DayOfWeek.Saturday && timeOfPurchase.DayOfWeek != DayOfWeek.Sunday)
            {
                return price / 10;
            }
            return 0;
        }
        #endregion
    }
}
