using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Q04
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One Discount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            decimal val = 0;
            if (quantity > 1) 
            {
                val = (price / 2) * (quantity / 2);
            }
            return val;
        }

        public override string ToString()
        {
            return $"Discount Type : {Name}";
        }
    }
}
