using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Food : Perishable
    {

        public Food (string name, string brand, double price, DateTime expirationDate) : base(name, brand, price, expirationDate)
        {
        }
    }
}
