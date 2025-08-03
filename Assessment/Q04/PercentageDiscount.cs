using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Q04
{
    internal class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }
        public PercentageDiscount(decimal _Percentage)
        {
            Percentage = _Percentage;
            Name = "Percentage Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * (decimal)quantity * (Percentage / 100);
        }

        public override string ToString()
        {
            return $"Discount Type : {Name}";
        }
    }
}
