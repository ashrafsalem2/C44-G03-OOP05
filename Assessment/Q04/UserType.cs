using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Q04
{
    internal class UserType : User
    {
        public string? Type { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public UserType(string _Name, string _Type, int quantity, decimal price)
        {
            Name = _Name;
            Type = _Type;
            Quantity = quantity;
            Price = price;
        }
        public override void GetDiscount()
        {
            switch (Type) 
            {
                case "Regular":
                    Discount discount =new  PercentageDiscount(5);
                    Console.WriteLine($"Discount Earned: {discount.CalculateDiscount(Price, Quantity)}");
                    Console.WriteLine($"Total Price Berfore Discount: {Quantity * Price}, Total Price After Discount: {(Quantity * Price) - discount.CalculateDiscount(Price, Quantity)}");
                    break;
                case "Premium":
                    Discount discount2 = new FlatDiscount(100);
                    Console.WriteLine($"Discount Earned: {discount2.CalculateDiscount(Price, Quantity)}");
                    Console.WriteLine($"Total Price Berfore Discount: {Quantity * Price}, Total Price After Discount: {(Quantity * Price) - discount2.CalculateDiscount(Price, Quantity)}");
                    break;
                case "Guest":
                default:
                    Console.WriteLine("No Discount Allowed sorry :(");
                    Console.WriteLine($"Total Price : {Quantity * Price}"); 
                    break;
              
            }
            
        }
    }
}
