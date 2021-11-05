using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Appliance : Product
    {
        #region Attributes
        private string model { get; set; }
        private DateTime productionDate { get; set; }
        private double weight { get; set; }

        #endregion

        #region Constructors
        public Appliance(string model, DateTime productionDate, double weight,string name, string brand, double price) : base(name, brand, price)
        {
            this.model = model;
            this.productionDate = productionDate;
            this.weight = weight;
        }

        #endregion

        #region Methods
        public override double getDiscount(DateTime timeOfPurchase)
        {
            if((timeOfPurchase.DayOfWeek == DayOfWeek.Saturday || timeOfPurchase.DayOfWeek == DayOfWeek.Sunday) && price > 999)
            {
                return price / 20;
            }
            return 0;
        }
        #endregion
    }
}
