using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Q04
{
    internal class FlatDiscount : Discount
    {
        public decimal Dudction { get; set; }

        public FlatDiscount(decimal _Dudction)
        {
            Dudction = _Dudction;
            Name = "fixed amount to be deducted ";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return Dudction * (decimal)Math.Min(quantity, 1);
        }
        public override string ToString()
        {
            return $"Discount Type : {Name}";
        }
    }
}
