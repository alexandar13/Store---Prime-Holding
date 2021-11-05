using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Beverage : Perishable
    {

        public Beverage(string name, string brand, double price, DateTime expirationDate) : base(name, brand, price, expirationDate)
        {
        }
    }
}
